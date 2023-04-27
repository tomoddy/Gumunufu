using Gumunufu.Objects;
using System.ComponentModel;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// All transactions form
    /// </summary>
    public partial class TotalBy : Form
    {
        /// <summary>
        /// Total by argument
        /// </summary>
        private string Argument { get; set; }

        /// <summary>
        /// List of transactions
        /// </summary>
        private List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transactions</param>
        public TotalBy(string argument, List<Transaction> transactions)
        {
            InitializeComponent();
            Icon = new Icon(Config.Icon);
            Text += argument;
            Argument = argument;
            Transactions = transactions;
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void TotalBy_Load(object sender, EventArgs e)
        {
            // Add columns
            TotalByTable.Columns.Add(Argument, Argument);
            TotalByTable.Columns.Add(Config.AMOUNT, Config.AMOUNT);

            // Format amount column
            TotalByTable.Columns[Config.AMOUNT].DefaultCellStyle.Format = Config.CURRENCY_FORMAT;
            TotalByTable.Columns[Config.AMOUNT].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            TotalByTable.Columns[Config.AMOUNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Get values
            Dictionary<string, float> nameTotalSet = GetValues(Argument);

            // Populate table
            foreach (KeyValuePair<string, float> nameTotalPair in nameTotalSet)
            {
                DataGridViewRow newRow = new();
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = nameTotalPair.Key });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = nameTotalPair.Value });
                TotalByTable.Rows.Add(newRow);
            }

            // Resize columns and set default sort
            TotalByTable.AutoResizeColumns();
            TotalByTable.Sort(TotalByTable.Columns[Argument], ListSortDirection.Ascending);

            // Size form
            Width = TotalByTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + Config.DGV_MARGIN;
        }

        /// <summary>
        /// Get values by argument
        /// </summary>
        /// <param name="argument">Argument</param>
        /// <returns>Dictionary of totals</returns>
        private Dictionary<string, float> GetValues(string argument)
        {
            // Create return value and get all unique labels
            Dictionary<string, float> retVal = new();
            List<string?> labels = GetLabels(argument);

            // Get data
            foreach (string? label in labels)
            {
                if (label is not null)
                {
                    if (argument == Config.ACCOUNT)
                        retVal.Add(label, Transactions.Where(t => t.Account == label).Sum(t => t.Amount));
                    else if (argument == Config.CATEGORY)
                        retVal.Add(label, Transactions.Where(t => t.Category == label).Sum(t => t.Amount));
                    else if (argument == Config.NAME)
                        retVal.Add(label, Transactions.Where(t => t.Name == label).Sum(t => t.Amount));
                }
            }

            // Return dictionary
            return retVal;
        }

        /// <summary>
        /// Get labels from argument
        /// </summary>
        /// <param name="argument">Argument</param>
        /// <returns>List of labels</returns>
        private List<string?> GetLabels(string argument)
        {
            return argument switch
            {
                Config.ACCOUNT => Transactions.Select(t => t.Account).Distinct().ToList(),
                Config.CATEGORY => Transactions.Select(t => t.Category).Distinct().ToList(),
                Config.NAME => Transactions.Select(t => t.Name).Distinct().ToList(),
                _ => new List<string?>(),
            };
        }
    }
}