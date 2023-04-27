using Gumunufu.Objects;
using System.ComponentModel;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// All transactions form
    /// </summary>
    public partial class TransactionView : Form
    {
        /// <summary>
        /// List of transactions
        /// </summary>
        private List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transactions</param>
        public TransactionView(List<Transaction> transactions)
        {
            InitializeComponent();
            Icon = new Icon(Config.Icon);
            Transactions = transactions;
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void TransactionView_Load(object sender, EventArgs e)
        {
            // Add columns
            TransactionViewTable.Columns.Add(Config.DATE, Config.DATE);
            TransactionViewTable.Columns.Add(Config.ACCOUNT, Config.ACCOUNT);
            TransactionViewTable.Columns.Add(Config.CATEGORY, Config.CATEGORY);
            TransactionViewTable.Columns.Add(Config.NAME, Config.NAME);
            TransactionViewTable.Columns.Add(Config.AMOUNT, Config.AMOUNT);

            // Format date column
            TransactionViewTable.Columns[Config.DATE].DefaultCellStyle.Format = Config.SHORT_DATE;

            // Format amount column
            TransactionViewTable.Columns[Config.AMOUNT].DefaultCellStyle.Format = Config.CURRENCY_FORMAT;
            TransactionViewTable.Columns[Config.AMOUNT].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            TransactionViewTable.Columns[Config.AMOUNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Populate table
            foreach (Transaction transaction in Transactions)
            {
                DataGridViewRow newRow = new();
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Date });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Account });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Category });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Name });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Amount });
                TransactionViewTable.Rows.Add(newRow);
            }

            // Resize columns and set default sort
            TransactionViewTable.AutoResizeColumns();
            TransactionViewTable.Sort(TransactionViewTable.Columns[Config.DATE], ListSortDirection.Descending);

            // Size form
            Width = TransactionViewTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + Config.DGV_MARGIN;
        }
    }
}
