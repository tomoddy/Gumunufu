using Gumunufu.Globals;

namespace Gumunufu.Objects
{
    /// <summary>
    /// Transaction set
    /// </summary>
    public class TransactionSet
    {
        /// <summary>
        /// List of transactions
        /// </summary>
        internal List<Transaction> Transactions { get; set; }

        /// <summary>
        /// List of categorised transactions
        /// </summary>
        internal List<Transaction> CategorisedTransactions => Transactions.Where(t => t.Category != null).OrderBy(t => t.Date).ToList();

        /// <summary>
        /// Uncategories transactions
        /// </summary>
        internal List<Transaction> UncategoriedTransactions => Transactions.Where(t => t.Category is null).ToList();

        /// <summary>
        /// List of accounts
        /// </summary>
        internal List<string> Accounts { get; set; }

        /// <summary>
        /// List of categories
        /// </summary>
        internal List<string> Categories { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        internal DateTime StartDate => Transactions.OrderBy(t => t.Date).Select(t => t.Date).First();

        /// <summary>
        /// Minimum amount
        /// </summary>
        internal float MinAmount => Transactions.OrderBy(t => t.Amount).Select(t => t.Amount).First();

        /// <summary>
        /// Maximum amount
        /// </summary>
        internal float MaxAmount => Transactions.OrderByDescending(t => t.Amount).Select(t => t.Amount).First();

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transaction</param>
        internal TransactionSet(List<Transaction> transactions)
        {
            // Set transactions, get accounts and categories
            Transactions = transactions;
            Accounts = Transactions.Where(t => t.Account is not null).Select(t => t.Account).Distinct().Cast<string>().ToList();
            Categories = CategorisedTransactions.Where(t => t.Category is not null).OrderBy(t => t.Category).Select(t => t.Category).Distinct().Cast<string>().ToList();

            // Check if config option overrides column selection
            if (Categories.All(Config.ColumnOrder.Contains))
                Categories = Config.ColumnOrder;
        }

        /// <summary>
        /// Get cell data
        /// </summary>
        /// <param name="period">Month</param>
        /// <param name="category">Category</param>
        /// <returns>Cell data</returns>
        internal CellData GetCellData(DateTime period, string category)
        {
            List<Transaction> transactions = CategorisedTransactions
                .Where(t => t.Category == category)
                .Where(t => t.Date.Year == period.Year)
                .Where(t => t.Date.Month == period.Month).ToList();
            return new CellData(category, period, transactions.Sum(x => x.Amount), transactions);
        }
    }
}