using Gumunufu.Globals;
using Gumunufu.Helpers;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Query selector form
    /// </summary>
    public partial class QuerySelector : Form
    {
        /// <summary>
        /// List of transactions
        /// </summary>
        internal List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        private DateTime StartDate { get; set; }

        /// <summary>
        /// List of accounts
        /// </summary>
        private List<string> Accounts { get; set; }

        /// <summary>
        /// List of categories
        /// </summary>
        private List<string> Categories { get; set; }

        /// <summary>
        /// Minimum amount
        /// </summary>
        private float MinAmount { get; set; }

        /// <summary>
        /// Maximum amount
        /// </summary>
        private float MaxAmount { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transactions</param>
        /// <param name="startDate">Start date</param>
        /// <param name="accounts">List of accounts</param>
        /// <param name="categories">List of categories</param>
        /// <param name="minAmount">Minimum amount</param>
        /// <param name="maxAmount">Maximum amount</param>
        public QuerySelector(List<Transaction> transactions, DateTime startDate, List<string> accounts, List<string> categories, float minAmount, float maxAmount)
        {
            InitializeComponent();
            Transactions = transactions;
            StartDate = startDate;
            Accounts = accounts;
            Categories = categories;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelector_Load(object sender, EventArgs e)
        {
            // Set default values
            QuerySelectorStartDatePicker.Value = StartDate;
            QuerySelectorEndDatePicker.Value = DateTime.Now;
            QuerySelectorAccountInput.Items.AddRange(Accounts.Cast<object>().ToArray());
            QuerySelectorCategoryInput.Items.AddRange(Categories.Cast<object>().ToArray());

            // Set min input default
            if(MinAmount < 0)
            {
                QuerySelectorMinNegativeCheckbox.Checked = true;
                QuerySelectorMinInput.Text = (MinAmount * -1).ToString(Resource.Argument.CURRENCY_FORMAT);
            }
            else
                QuerySelectorMinInput.Text = MinAmount.ToString(Resource.Argument.CURRENCY_FORMAT);

            // Set max input default
            if (MaxAmount < 0)
            {
                QuerySelectorMaxNegativeCheckbox.Checked = true;
                QuerySelectorMaxInput.Text = (MaxAmount * -1).ToString(Resource.Argument.CURRENCY_FORMAT);
            }
            else
                QuerySelectorMaxInput.Text = MaxAmount.ToString(Resource.Argument.CURRENCY_FORMAT);
        }

        /// <summary>
        /// Submit click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelectorSubmit_Click(object sender, EventArgs e)
        {
            // Check amount can be parsed correctly
            if (StringHelper.CurrencyParse(QuerySelectorMinInput.Text, out float minInput) && StringHelper.CurrencyParse(QuerySelectorMaxInput.Text, out float maxInput))
            {
                // Format minimum input
                minInput /= 100;
                if (QuerySelectorMinNegativeCheckbox.Checked)
                    minInput *= -1;

                // Format maximum output
                maxInput /= 100;
                if (QuerySelectorMaxNegativeCheckbox.Checked)
                    maxInput *= -1;

                // Get selected accounts
                List<string> selectedAccounts = new();
                foreach(var item in QuerySelectorAccountInput.CheckedItems)
                    selectedAccounts.Add(item.ToString()!);

                // Get selected categories
                List<string> selectedCategories = new();
                foreach (var item in QuerySelectorCategoryInput.CheckedItems)
                    selectedCategories.Add(item.ToString()!);

                // Query transactions
                Transactions = Transactions
                    .Where(t => t.Date >= QuerySelectorStartDatePicker.Value)
                    .Where(t => t.Date <= QuerySelectorEndDatePicker.Value)
                    .Where(t => t.Amount >= minInput)
                    .Where(t => t.Amount <= maxInput)
                    .ToList();

                // Check if all accounts selected
                if (!QuerySelectorAccountAllCheckBox.Checked)
                    Transactions = Transactions.Where(t => selectedAccounts.Contains(t.Account!)).ToList();

                // Check if all categories selected
                if (!QuerySelectorCategoryAllCheckBox.Checked)
                    Transactions = Transactions.Where(t => selectedCategories.Contains(t.Category!)).ToList();

                // Set dialog result
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// All accounts checkbox changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelectorAccountAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            QuerySelectorAccountInput.Enabled = !QuerySelectorAccountAllCheckBox.Checked;
        }

        /// <summary>
        /// All categories checkbox changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelectorCategoryAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            QuerySelectorCategoryInput.Enabled = !QuerySelectorCategoryAllCheckBox.Checked;
        }

        /// <summary>
        /// Min text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelectorMinInput_TextChanged(object sender, EventArgs e)
        {
            // Remove previous formatting and parse to float
            if (StringHelper.CurrencyParse(QuerySelectorMinInput.Text, out float value))
            {
                // Format the text as currency
                value /= 100;
                QuerySelectorMinInput.TextChanged -= QuerySelectorMinInput_TextChanged!;
                QuerySelectorMinInput.Text = string.Format(CultureInfo.CreateSpecificCulture(Resource.Argument.LOCALE), Resource.Argument.CURRENCY_FORMAT_INPUT, value);
                QuerySelectorMinInput.TextChanged += QuerySelectorMinInput_TextChanged!;
                QuerySelectorMinInput.Select(QuerySelectorMinInput.Text.Length, 0);
            }

            // Check if format is valid
            bool validFormat = StringHelper.FormatIsValid(QuerySelectorMinInput.Text);
            QuerySelectorSubmit.Enabled = validFormat;

            // Reset text if not valid
            if (!validFormat)
            {
                QuerySelectorMinInput.Text = Resource.Argument.CURRENCT_DEFAULT;
                QuerySelectorMinInput.Select(QuerySelectorMinInput.Text.Length, 0);
            }
        }

        /// <summary>
        /// Max text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void QuerySelectorMaxInput_TextChanged(object sender, EventArgs e)
        {
            // Remove previous formatting and parse to float
            if (StringHelper.CurrencyParse(QuerySelectorMaxInput.Text, out float value))
            {
                // Format the text as currency
                value /= 100;
                QuerySelectorMaxInput.TextChanged -= QuerySelectorMaxInput_TextChanged!;
                QuerySelectorMaxInput.Text = string.Format(CultureInfo.CreateSpecificCulture(Resource.Argument.LOCALE), Resource.Argument.CURRENCY_FORMAT_INPUT, value);
                QuerySelectorMaxInput.TextChanged += QuerySelectorMaxInput_TextChanged!;
                QuerySelectorMaxInput.Select(QuerySelectorMaxInput.Text.Length, 0);
            }

            // Check if format is valid
            bool validFormat = StringHelper.FormatIsValid(QuerySelectorMaxInput.Text);
            QuerySelectorSubmit.Enabled = validFormat;

            // Reset text if not valid
            if (!validFormat)
            {
                QuerySelectorMaxInput.Text = Resource.Argument.CURRENCT_DEFAULT;
                QuerySelectorMaxInput.Select(QuerySelectorMaxInput.Text.Length, 0);
            }
        }
    }
}