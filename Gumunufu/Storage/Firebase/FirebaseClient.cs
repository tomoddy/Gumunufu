using Google.Cloud.Firestore;
using Gumunufu.Globals;
using Gumunufu.Objects;

namespace Gumunufu.Storage.Firebase
{
    /// <summary>
    /// Firebase client
    /// </summary>
    public class FirebaseClient : IStorageClient
    {
        /// <summary>
        /// Database
        /// </summary>
        private FirestoreDb Database { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        private string Username { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="path">Path to key file</param>
        /// <param name="database">Database name</param>
        /// <param name="username">Username</param>
        public FirebaseClient(string path, string database, string username)
        {
            Environment.SetEnvironmentVariable(Resource.Firebase.GOOGLE_APPLICATION_CREDENTIALS, path);
            Database = FirestoreDb.Create(database);
            Username = username;
        }

        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        public TransactionSet GetTransactions()
        {
            DocumentReference reference = Database.Collection(Resource.Firebase.USERS).Document(Username).Collection(Resource.Firebase.TRANSACTION_SETS).Document(GetLatestTransactionSetGuid());
            Dictionary<string, object> transactionMap = reference.GetSnapshotAsync().GetAwaiter().GetResult().ToDictionary();

            List<Objects.Transaction> transactions = new();
            foreach (Dictionary<string, object> transaction in transactionMap.Values.Cast<Dictionary<string, object>>())
                transactions.Add(new Objects.Transaction
                {
                    Date = ((Timestamp)transaction[Resource.Literal.DATE]).ToDateTime(),
                    Account = (string)transaction[Resource.Literal.ACCOUNT],
                    Name = (string)transaction[Resource.Literal.NAME],
                    Amount = (float)(double)transaction[Resource.Literal.AMOUNT],
                    Category = (string)transaction[Resource.Literal.CATEGORY],
                });

            return new TransactionSet(transactions);
        }

        /// <summary>
        /// Update database
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        public void UpdateTransactions(TransactionSet transactionSet)
        {
            string transactionSetGuid = Guid.NewGuid().ToString();
            DocumentReference reference = Database.Collection(Resource.Firebase.USERS).Document(Username).Collection(Resource.Firebase.TRANSACTION_SETS).Document(transactionSetGuid);

            Dictionary<string, Objects.Transaction> transactionMap = new();
            foreach (Objects.Transaction transaction in transactionSet.Transactions)
                transactionMap.Add(Guid.NewGuid().ToString(), transaction);

            WriteBatch batch = Database.StartBatch();
            batch.Set(reference, transactionMap);
            batch.CommitAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get guid of latest transaction set
        /// </summary>
        /// <returns>Guid as string</returns>
        private string GetLatestTransactionSetGuid()
        {
            Dictionary<string, Timestamp> transactionSets = new();
            Query query = Database.Collection(Resource.Firebase.USERS).Document(Username).Collection(Resource.Firebase.TRANSACTION_SETS);

            foreach (DocumentSnapshot snapshot in query.GetSnapshotAsync().GetAwaiter().GetResult().Documents)
                transactionSets.Add(snapshot.Id, snapshot.CreateTime!.Value);

            return transactionSets.OrderByDescending(t => t.Value).Select(t => t.Key).First();
        }
    }
}