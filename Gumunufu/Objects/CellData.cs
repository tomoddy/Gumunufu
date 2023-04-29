namespace Gumunufu.Objects
{
    /// <summary>
    /// Cell data
    /// </summary>
    internal class CellData
    {
        /// <summary>
        /// Category
        /// </summary>
        internal string Category { get; set; }

        /// <summary>
        /// Month
        /// </summary>
        internal DateTime Month { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        internal float Total { get; set; }

        /// <summary>
        /// List of transactions
        /// </summary>
        internal List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="month">Month</param>
        /// <param name="total">Total</param>
        /// <param name="transactions">List of transactions</param>
        internal CellData(string category, DateTime month, float total, List<Transaction> transactions)
        {
            Category = category;
            Month = month;
            Total = total;
            Transactions = new List<Transaction>(transactions);
        }

        /// <summary>
        /// Total constructor
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="month">Month</param>
        internal CellData(string category, DateTime month)
        {
            Category = category;
            Month = month;
            Total = 0;
            Transactions = new List<Transaction>();
        }
    }
}