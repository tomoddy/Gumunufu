using Gumunufu.Objects;

namespace Gumunufu.Storage
{
    /// <summary>
    /// Stroage client interface
    /// </summary>
    internal interface IStorageClient
    {
        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        internal TransactionSet GetTransactions();

        /// <summary>
        /// Update database
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        internal void UpdateTransactions(TransactionSet transactionSet);
    }
}
