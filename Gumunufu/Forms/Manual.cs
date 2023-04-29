using Gumunufu.Globals;
using Gumunufu.Helpers;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Manual add dialog
    /// </summary>
    public partial class Manual : Form
    {
        /// <summary>
        /// New transaction
        /// </summary>
        internal Transaction Transaction { get; set; }

        /// <summary>
        /// Add constructor
        /// </summary>
        public Manual()
        {
            InitializeComponent();
            Text = Resource.Message.ADD_TRANSACTION;
            ManualDelete.Enabled = false;
            ManualDelete.Visible = false;
            Transaction = new Transaction
            {
                Date = DateTime.Now,
                Account = Resource.Literal.GUNUFUFU,
                Category = string.Empty,
                Name = Resource.Literal.GUNUFUFU,
                Amount = 0
            };
        }

        /// <summary>
        /// Edit constructor
        /// </summary>
        /// <param name="transaction">Transaction</param>
        public Manual(Transaction transaction)
        {
            InitializeComponent();
            Text = Resource.Message.EDIT_TRANSACTION;
            Transaction = transaction;
        }

        /// <summary>
        /// Manual add event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Manual_Load(object sender, EventArgs e)
        {
            // Set default values
            ManualDatePicker.Value = Transaction.Date;
            ManualAccountInput.Text = Transaction.Account;
            ManualCategoryInput.Text = Transaction.Category;
            ManualNameInput.Text = Transaction.Name;

            // Set amount and format
            float amount = Transaction.Amount * 100;
            if (amount < 0)
            {
                amount *= -1;
                ManualNegativeCheckBox.Checked = true;
            }
            ManualAmountInput.Text = amount.ToString();
            ManualAmountInput_TextChanged(sender, e);
        }

        /// <summary>
        /// Amount input text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualAmountInput_TextChanged(object sender, EventArgs e)
        {
            // Remove previous formatting and parse to float
            if (StringHelper.CurrencyParse(ManualAmountInput.Text, out float value))
            {
                // Format the text as currency
                value /= 100;
                ManualAmountInput.TextChanged -= ManualAmountInput_TextChanged!;
                ManualAmountInput.Text = string.Format(CultureInfo.CreateSpecificCulture(Resource.Argument.LOCALE), Resource.Argument.CURRENCY_FORMAT_INPUT, value);
                ManualAmountInput.TextChanged += ManualAmountInput_TextChanged!;
                ManualAmountInput.Select(ManualAmountInput.Text.Length, 0);
            }

            // Check if format is valid
            bool validFormat = StringHelper.FormatIsValid(ManualAmountInput.Text);
            ManualSave.Enabled = validFormat;

            // Reset text if not valid
            if (!validFormat)
            {
                ManualAmountInput.Text = Resource.Argument.CURRENCY_DEFAULT;
                ManualAmountInput.Select(ManualAmountInput.Text.Length, 0);
            }
        }

        /// <summary>
        /// Delete event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        /// <summary>
        /// Submit event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualSave_Click(object sender, EventArgs e)
        {
            // Add basic elements to new transaction 
            Transaction.Date = ManualDatePicker.Value;
            Transaction.Account = ManualAccountInput.Text;
            Transaction.Name = ManualNameInput.Text;
            Transaction.Category = ManualCategoryInput.Text;

            // Parse float and set value
            if (StringHelper.CurrencyParse(ManualAmountInput.Text, out float value))
            {
                // Invert value if negative
                if (ManualNegativeCheckBox.Checked)
                    value *= -1;

                // Add transaction amount and close dialog
                Transaction.Amount = value / 100;
                DialogResult = DialogResult.OK;
            }
        }
    }
}