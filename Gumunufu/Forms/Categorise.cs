using Gumunufu.Objects;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Categorise form
    /// </summary>
    public partial class Categorise : Form
    {
        /// <summary>
        /// New item
        /// </summary>
        private const string NEW_CATEGORY = "New...";

        /// <summary>
        /// Coorindate offset
        /// </summary>
        private const int OFFSET = 100;

        /// <summary>
        /// Base location
        /// </summary>
        private Point BaseLocation { get; set; }

        /// <summary>
        /// List of categories
        /// </summary>
        private List<string> Categories { get; set; }

        /// <summary>
        /// Current transaction
        /// </summary>
        internal Transaction Transaction { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="baseLocation">Base location of main form</param>
        /// <param name="categories">Categories</param>
        /// <param name="transaction">Transaction</param>
        public Categorise(Point baseLocation, List<string> categories, ref Transaction transaction)
        {
            InitializeComponent();
            BaseLocation = baseLocation;
            Categories = categories;
            Transaction = transaction;
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Categorise_Load(object sender, EventArgs e)
        {
            // Set form position
            Left = BaseLocation.X + OFFSET;
            Top = BaseLocation.Y + OFFSET;

            // Load transaction info
            CategoriseDateLabel.Text = Transaction.Date.ToString("dd/MM/yyyy");
            CategoriseNameLabel.Text = Transaction.Name;
            CategoriseAmountLabel.Text = Transaction.Amount.ToString(Home.CURRENCY_FORMAT);

            // Load list view
            CategoriseListView.BeginUpdate();
            CategoriseListView.Items.Add(NEW_CATEGORY);
            foreach (string category in Categories)
                CategoriseListView.Items.Add(category);
            CategoriseListView.EndUpdate();
        }

        /// <summary>
        /// Submit click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void CategoriseSubmit_Click(object sender, EventArgs e)
        {
            string selectedCategory = CategoriseListView.SelectedItems[0].Text;
            if (selectedCategory == NEW_CATEGORY)
                throw new NotImplementedException();
            else
            {
                Transaction.Category = selectedCategory;
                DialogResult = DialogResult.OK;
            }
        }
    }
}