using Google.Cloud.Firestore;

namespace Gumunufu.Objects
{
    /// <summary>
    /// Transaction object
    /// </summary>
    [FirestoreData]
    public class Transaction
    {
        /// <summary>
        /// Date
        /// </summary>
        private DateTime _Date;
        [FirestoreProperty]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = DateTime.SpecifyKind(value, DateTimeKind.Utc); }
        }

        /// <summary>
        /// Account
        /// </summary>
        [FirestoreProperty]
        public string? Account { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [FirestoreProperty]
        public string? Name { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [FirestoreProperty]
        public float Amount { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [FirestoreProperty]
        public string? Category { get; set; }
    }
}