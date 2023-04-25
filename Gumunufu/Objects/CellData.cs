namespace Gumunufu.Objects
{
    /// <summary>
    /// Cell data
    /// </summary>
    internal class CellData
    {
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
        /// <param name="total">Total</param>
        /// <param name="transactions">List of transactions</param>
        internal CellData(float total, List<Transaction> transactions)
        {
            Total = total;
            Transactions = transactions;
        }
    }
}