namespace Gumunufu.Objects
{
    /// <summary>
    /// Transaction updates
    /// </summary>
    internal class TransactionUpdate
    {
        /// <summary>
        /// List of transactions to add
        /// </summary>
        internal List<Transaction> Edit { get; set; }

        /// <summary>
        /// List of transactions to remove
        /// </summary>
        internal List<Transaction> Delete { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        internal TransactionUpdate()
        {
            Edit = new List<Transaction>();
            Delete = new List<Transaction>();
        }
    }
}