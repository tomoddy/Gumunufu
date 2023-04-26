using Gumunufu.Objects;
using System.Globalization;
using System.Text.RegularExpressions;

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
            Icon = new Icon(Config.Icon);
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
            NewTransaction.Name = ManualAddNameInput.Text;
            NewTransaction.Category = ManualAddCategoryInput.Text;

            // Parse float and set value
            if (float.TryParse(ManualAddAmountInput.Text.Replace(",", string.Empty).Replace("£", string.Empty).Replace(".", string.Empty).TrimStart('0'), out float value))
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
            if (float.TryParse(ManualAddAmountInput.Text.Replace(",", string.Empty).Replace("£", string.Empty).Replace(".", string.Empty).TrimStart('0'), out float value))
            {
                // Format the text as currency
                value /= 100;
                ManualAddAmountInput.TextChanged -= ManualAddAmountInput_TextChanged!;
                ManualAddAmountInput.Text = string.Format(CultureInfo.CreateSpecificCulture("en-GB"), "{0:C2}", value);
                ManualAddAmountInput.TextChanged += ManualAddAmountInput_TextChanged!;
                ManualAddAmountInput.Select(ManualAddAmountInput.Text.Length, 0);
            }

            // Check if format is valid
            bool validFormat = FormatIsValid(ManualAddAmountInput.Text);
            ManualAddSubmit.Enabled = validFormat;

            // Reset text if not valid
            if (!validFormat)
            {
                ManualAddAmountInput.Text = "£0.00";
                ManualAddAmountInput.Select(ManualAddAmountInput.Text.Length, 0);
            }
        }

        /// <summary>
        /// Checks regex of currency format
        /// </summary>
        /// <param name="text">Input text</param>
        /// <returns>True if valid, false otherwise</returns>
        private static bool FormatIsValid(string text)
        {
            Regex money = new(@"^\£(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }
    }
}