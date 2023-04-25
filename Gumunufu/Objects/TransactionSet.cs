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
        /// List of categories
        /// </summary>
        internal List<string> Categories { get; set; }

        internal TransactionSet(List<Transaction> transactions)
        {
            // Sort transactions by date
            Transactions = transactions.OrderBy(x => x.Date).ToList();

            // Get non null, distinct cateogies sorted alphabetically
            Categories = Transactions.Where(x => x.Category is not null).Select(x => x.Category).Distinct().Cast<string>().ToList();
            Categories.Sort();
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