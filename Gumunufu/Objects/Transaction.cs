namespace Gumunufu.Objects
{
    /// <summary>
    /// Transaction object
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public string? Category { get; set; }
    }
}