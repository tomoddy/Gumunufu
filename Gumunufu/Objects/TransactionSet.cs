namespace Gumunufu.Objects
{
    /// <summary>
    /// Transaction set
    /// </summary>
    internal class TransactionSet
    {
        /// <summary>
        /// List of transactions
        /// </summary>
        internal List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Uncategories transactions
        /// </summary>
        internal List<Transaction> UncategoriedTransactions { get; set; }

        /// <summary>
        /// List of categories
        /// </summary>
        internal List<string> Categories { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transaction</param>
        internal TransactionSet(List<Transaction> transactions)
        {
            // Sort transactions by category and date
            Transactions = transactions.Where(t => t.Category != null).OrderBy(t => t.Date).ToList();
            UncategoriedTransactions = transactions.Where(t => t.Category is null).ToList();

            // Get non null, distinct cateogies sorted alphabetically
            Categories = Transactions.Where(t => t.Category is not null).OrderBy(t => t.Category).Select(t => t.Category).Distinct().Cast<string>().ToList();

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
            List<Transaction> transactions = Transactions
                .Where(t => t.Category == category)
                .Where(t => t.Date.Year == period.Year)
                .Where(t => t.Date.Month == period.Month).ToList();
            return new CellData(transactions.Sum(x => x.Amount), transactions);
        }
    }
}