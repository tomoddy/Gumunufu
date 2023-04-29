using Gumunufu.Objects;

namespace Gumunufu.Storage
{
    /// <summary>
    /// Stroage client interface
    /// </summary>
    internal interface IStorageClient
    {
        /// <summary>
        /// Check if user is valid
        /// </summary>
        /// <returns>True if valid, false otherwise</returns>
        internal abstract bool CheckCredentials();

        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        internal abstract TransactionSet GetTransactions();

        /// <summary>
        /// Update database
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        internal abstract void UpdateTransactions(TransactionSet transactionSet);
    }
}