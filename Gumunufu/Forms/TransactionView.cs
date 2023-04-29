using Gumunufu.Globals;
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
        /// Transaction updates
        /// </summary>
        internal TransactionUpdate Updates { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="transactions">List of transactions</param>
        public TransactionView(List<Transaction> transactions)
        {
            InitializeComponent();
            Icon = new Icon(Config.Icon);
            Transactions = new List<Transaction>(transactions);
            Updates = new TransactionUpdate();
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void TransactionView_Load(object sender, EventArgs e)
        {
            // Clear table
            TransactionViewTable.Columns.Clear();

            // Add columns
            TransactionViewTable.Columns.Add(Resource.Literal.DATE, Resource.Literal.DATE);
            TransactionViewTable.Columns.Add(Resource.Literal.ACCOUNT, Resource.Literal.ACCOUNT);
            TransactionViewTable.Columns.Add(Resource.Literal.CATEGORY, Resource.Literal.CATEGORY);
            TransactionViewTable.Columns.Add(Resource.Literal.NAME, Resource.Literal.NAME);
            TransactionViewTable.Columns.Add(Resource.Literal.AMOUNT, Resource.Literal.AMOUNT);

            // Format date column
            TransactionViewTable.Columns[Resource.Literal.DATE].DefaultCellStyle.Format = Resource.Argument.SHORT_DATE;

            // Format amount column
            TransactionViewTable.Columns[Resource.Literal.AMOUNT].DefaultCellStyle.Format = Resource.Argument.CURRENCY_FORMAT;
            TransactionViewTable.Columns[Resource.Literal.AMOUNT].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            TransactionViewTable.Columns[Resource.Literal.AMOUNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Populate table
            foreach (Transaction transaction in Transactions)
            {
                DataGridViewRow newRow = new();
                newRow.Tag = transaction;
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Date });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Account });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Category });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Name });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = transaction.Amount });
                TransactionViewTable.Rows.Add(newRow);
            }

            // Resize columns and set default sort
            TransactionViewTable.AutoResizeColumns();
            TransactionViewTable.Sort(TransactionViewTable.Columns[Resource.Literal.DATE], ListSortDirection.Descending);

            // Size form
            Width = TransactionViewTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + Resource.Argument.DGV_MARGIN;
        }

        /// <summary>
        /// Cell double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void TransactionViewTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get transaction and create dialog
            Transaction transaction = (Transaction)TransactionViewTable.Rows[e.RowIndex].Tag!;
            Manual manualEdit = new(transaction);
            DialogResult result = manualEdit.ShowDialog();

            // Check dialog result for saved (OK) or deleted (Abort)
            if (result == DialogResult.OK || result == DialogResult.Abort)
            {
                // Add to edited transaction if saved (OK)
                if (result == DialogResult.OK)
                    Updates.Edit.Add(manualEdit.Transaction);

                // Add transactions to delete
                Updates.Delete.Add(transaction);
                TransactionView_Load(sender, e);
            }
        }
    }
}