using Gumunufu.Objects;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Categorise form
    /// </summary>
    public partial class Categorise : Form
    {
        /// <summary>
        /// List of categories
        /// </summary>
        private List<string> Categories { get; set; }

        /// <summary>
        /// Uncategorised transactions
        /// </summary>
        private List<Transaction> UncategorisedTransactions { get; set; }

        /// <summary>
        /// Categorised transactions
        /// </summary>
        internal List<Transaction> CategorisedTransactions { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="categories">Categories</param>
        /// <param name="uncategorisedTransactions">Uncategorised transactions</param>
        public Categorise(List<string> categories, List<Transaction> uncategorisedTransactions)
        {
            InitializeComponent();
            Categories = categories;
            UncategorisedTransactions = uncategorisedTransactions;
            CategorisedTransactions = new List<Transaction>();
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Categorise_Load(object sender, EventArgs e)
        {
            // Load first transaction
            LoadNextTransaction();
        }

        /// <summary>
        /// Load next transaction
        /// </summary>
        private void LoadNextTransaction()
        {
            Transaction transaction = UncategorisedTransactions.First();
            CategoriseDateLabel.Text = transaction.Date.ToString("dd/MM/yyyy");
            CategoriseNameLabel.Text = transaction.Name;
            CategoriseAmountLabel.Text = transaction.Amount.ToString(Home.CURRENCY_FORMAT);
        }
    }
}