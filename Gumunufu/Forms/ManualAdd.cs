using Gumunufu.Globals;
using Gumunufu.Helpers;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Manual add dialog
    /// </summary>
    public partial class ManualAdd : Form
    {
        /// <summary>
        /// New transaction
        /// </summary>
        internal Transaction NewTransaction { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ManualAdd()
        {
            InitializeComponent();
            NewTransaction = new Transaction();
        }

        /// <summary>
        /// Manual add event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualAdd_Load(object sender, EventArgs e)
        {
            ManualAddDatePicker.Value = DateTime.Now;
            ManualAddAmountInput.Text = Resource.Argument.CURRENCT_DEFAULT;
        }

        /// <summary>
        /// Submit event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualAddSubmit_Click(object sender, EventArgs e)
        {
            // Add basic elements to new transaction 
            NewTransaction.Date = ManualAddDatePicker.Value;
            NewTransaction.Account = ManualAddAccountInput.Text;
            NewTransaction.Name = ManualAddNameInput.Text;
            NewTransaction.Category = ManualAddCategoryInput.Text;

            // Parse float and set value
            if (StringHelper.CurrencyParse(ManualAddAmountInput.Text, out float value))
            {
                // Invert value if negative
                if (ManualAddNegativeCheckBox.Checked)
                    value *= -1;

                // Add transaction amount and close dialog
                NewTransaction.Amount = value / 100;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Amount input text changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ManualAddAmountInput_TextChanged(object sender, EventArgs e)
        {
            // Remove previous formatting and parse to float
            if (StringHelper.CurrencyParse(ManualAddAmountInput.Text, out float value))
            {
                // Format the text as currency
                value /= 100;
                ManualAddAmountInput.TextChanged -= ManualAddAmountInput_TextChanged!;
                ManualAddAmountInput.Text = string.Format(CultureInfo.CreateSpecificCulture(Resource.Argument.LOCALE), Resource.Argument.CURRENCY_FORMAT_INPUT, value);
                ManualAddAmountInput.TextChanged += ManualAddAmountInput_TextChanged!;
                ManualAddAmountInput.Select(ManualAddAmountInput.Text.Length, 0);
            }

            // Check if format is valid
            bool validFormat = StringHelper.FormatIsValid(ManualAddAmountInput.Text);
            ManualAddSubmit.Enabled = validFormat;

            // Reset text if not valid
            if (!validFormat)
            {
                ManualAddAmountInput.Text = Resource.Argument.CURRENCT_DEFAULT;
                ManualAddAmountInput.Select(ManualAddAmountInput.Text.Length, 0);
            }
        }
    }
}