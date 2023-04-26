using Gumunufu.Helpers;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Home : Form
    {
        #region Properties and Events

        /// <summary>
        /// Month label
        /// </summary>
        private const string MONTH = "Month";

        /// <summary>
        /// Total label
        /// </summary>
        private const string TOTAL = "Total";

        /// <summary>
        /// Margin for resizing form
        /// </summary>
        private const int FORM_MARGIN = 200;

        /// <summary>
        /// Currency cell format
        /// </summary>
        public const string CURRENCY_FORMAT = "c2";

        /// <summary>
        /// Data client
        /// </summary>
        private DataClient Client { get; set; }

        /// <summary>
        /// Transaction set
        /// </summary>
        private TransactionSet TransactionSet { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Home()
        {
            InitializeComponent();
            Client = new(Config.Path);
            TransactionSet = new(Client.GetTransactions());
        }

        /// <summary>
        /// On load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Home_Load(object sender, EventArgs e)
        {
            // Clear table
            HomeTable.Columns.Clear();

            // Disable controls
            SetControls(false);

            // Populate controls
            PopulateMenuStrip();
            PopulateTable();

            // Enable controls
            SetControls(true);
        }

        private void SetControls(bool state)
        {
            HomeTable.Enabled = state;
            HomeMenuStrip.Enabled = state;
        }

        #endregion

        #region Menu Strip

        /// <summary>
        /// Populate menu strip
        /// </summary>
        /// <param name="uncategorisedCount">Number of uncategorised transactions</param>
        private void PopulateMenuStrip()
        {
            SetCategoriseLabel(TransactionSet.UncategoriedTransactions.Count);
        }

        /// <summary>
        /// Set the label for the categorise button
        /// </summary>
        /// <param name="count">Number of items</param>
        private void SetCategoriseLabel(int count)
        {
            if (count > 0)
            {
                HomeMenuStrip.Items["HomeMenuStripCategorise"].Enabled = true;
                HomeMenuStrip.Items["HomeMenuStripCategorise"].Text = $"Categorise ({count})";
            }
            else
            {
                HomeMenuStrip.Items["HomeMenuStripCategorise"].Enabled = false;
                HomeMenuStrip.Items["HomeMenuStripCategorise"].Text = "Categorise";
            }
        }

        /// <summary>
        /// Insert manual click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripInsertManual_Click(object sender, EventArgs e)
        {
            ManualAdd manualAdd = new();
            if (manualAdd.ShowDialog() == DialogResult.OK)
            {
                TransactionSet.Transactions.Add(manualAdd.NewTransaction);
                Client.UpdateTransactions(TransactionSet);
                Home_Load(sender, e);
            }
        }

        /// <summary>
        /// Categorise click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripCategorise_Click(object sender, EventArgs e)
        {
            // Categorise unset transactions
            while (TransactionSet.UncategoriedTransactions.Count > 0)
            {
                // Create transaction dialog
                Transaction uncategorisedTransaction = TransactionSet.UncategoriedTransactions.First();
                Categorise categoriseForm = new(Location, TransactionSet.Categories, ref uncategorisedTransaction);

                // Move transaction into main list if submitted
                if (categoriseForm.ShowDialog() == DialogResult.OK)
                {
                    TransactionSet.UncategoriedTransactions.Remove(uncategorisedTransaction);
                    TransactionSet.CategorisedTransactions.Add(uncategorisedTransaction);
                }
                else
                    break;

                // Add new category if option selected by user
                if (!string.IsNullOrEmpty(categoriseForm.NewCategory))
                    TransactionSet.Categories.Add(categoriseForm.NewCategory);
            }

            // Update database
            Client.UpdateTransactions(TransactionSet);

            // Reload form
            Home_Load(sender, e);
        }

        #endregion

        #region Table

        /// <summary>
        /// Populate table
        /// </summary>
        /// <param name="TransactionSet">Transaction set</param>
        private void PopulateTable()
        {
            // Add month header
            HomeTable.Columns.Add(MONTH, MONTH);

            // Add category headers
            foreach (string? category in TransactionSet.Categories)
            {
                int categoryIndex = HomeTable.Columns.Add(category, category);
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Format = CURRENCY_FORMAT;
                HomeTable.Columns[categoryIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Add total header
            int totalIndex = HomeTable.Columns.Add(TOTAL, TOTAL);
            HomeTable.Columns[totalIndex].DefaultCellStyle.Format = CURRENCY_FORMAT;
            HomeTable.Columns[totalIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            HomeTable.Columns[totalIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Iterate through months
            List<DateTime> months = GetRowLabels(Config.StartDate);
            List<float> monthTotal = new();
            foreach (DateTime month in months)
            {
                // Create new row
                DataGridViewRow newRow = new();
                float total = 0;

                // Add date
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = month.ToString("MMM yyyy"), Tag = month });

                // Add category totals
                foreach (string category in TransactionSet.Categories)
                {
                    // Create cell and add to row
                    CellData cellData = TransactionSet.GetCellData(month, category);
                    DataGridViewCell newCell = new DataGridViewTextBoxCell { Value = (int)cellData.Total != 0 ? cellData.Total : string.Empty, Tag = cellData };
                    newRow.Cells.Add(newCell);

                    // Add total to row total and month total list
                    total += cellData.Total;
                    monthTotal.Add(cellData.Total);
                }

                // Add total and add row to table
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = total });
                HomeTable.Rows.Add(newRow);
            }

            // Sort month total and colour cells
            monthTotal.Sort();
            ColourCells(TransactionSet.Categories, new ColourCalculator(monthTotal.First(), monthTotal.Last()));

            // Resize columns
            HomeTable.AutoResizeColumns();

            // Size form
            Width = HomeTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + FORM_MARGIN;
            Height = HomeTable.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + FORM_MARGIN;
        }

        /// <summary>
        /// Get row labels
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <returns>List of months</returns>
        private static List<DateTime> GetRowLabels(DateTime startDate)
        {
            // Create return list and date to add
            List<DateTime> retVal = new();
            DateTime dateToAdd = new(startDate.Year, startDate.Month, 1);

            // Add months while they are before current month
            do
            {
                retVal.Add(dateToAdd);
                dateToAdd = dateToAdd.AddMonths(1);
            }
            while (dateToAdd < DateTime.Now);

            // Return list
            return retVal;
        }

        /// <summary>
        /// Colour cells
        /// </summary>
        /// <param name="categories">List of categories</param>
        /// <param name="calculator">Colour calculator</param>
        private void ColourCells(List<string> categories, ColourCalculator calculator)
        {
            foreach (DataGridViewRow row in HomeTable.Rows)
                foreach (string category in categories)
                    row.Cells[category].Style.BackColor = calculator.GetColour(row.Cells[category].Tag);
        }

        #endregion
    }
}