using Gumunufu.Globals;
using Gumunufu.Helpers;
using Gumunufu.Helpers.DataImport;
using Gumunufu.Objects;
using Gumunufu.Storage;
using System.Globalization;

namespace Gumunufu.Forms
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Home : Form
    {
        #region Properties

        /// <summary>
        /// Storage client
        /// </summary>
        private IStorageClient Client { get; set; }

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
            Icon = new Icon(Config.Icon);
            Client = new StorageClient().CreateClient(Enum.Parse<StorageType>(Config.StorageType));
            TransactionSet = Client.GetTransactions();
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
                HomeMenuStrip.Items[Resource.Argument.STRIP_CATEGORISE].Enabled = true;
                HomeMenuStrip.Items[Resource.Argument.STRIP_CATEGORISE].Text = Resource.Message.Categorise(count);
            }
            else
            {
                HomeMenuStrip.Items[Resource.Argument.STRIP_CATEGORISE].Enabled = false;
                HomeMenuStrip.Items[Resource.Argument.STRIP_CATEGORISE].Text = Resource.Message.CATEGORISE;
            }
        }

        /// <summary>
        /// Insert from lloyds file click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripInsertFromFileLloyds_Click(object sender, EventArgs e)
        {
            // Create and show open file dialog
            OpenFileDialog fileDialog = new() { Filter = Resource.Argument.CSV_FILTER };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create dialog to get account name
                AccountInput accountInput = new();
                if (accountInput.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Try to import data
                        TransactionSet.Transactions.AddRange(FileImportClient.LloydsImport(fileDialog.FileName, accountInput.AccountName));
                        Client.UpdateTransactions(TransactionSet);
                        Home_Load(sender, e);
                    }
                    catch (FileImportException ex)
                    {
                        // Show error message
                        MessageBox.Show(Resource.Message.ImportError(ex), Resource.Message.IMPORT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Insert from monzo file click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStrupInsertFromFileMonzo_Click(object sender, EventArgs e)
        {
            // Create and show open file dialog
            OpenFileDialog fileDialog = new() { Filter = Resource.Argument.CSV_FILTER };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create dialog to get account name
                AccountInput accountInput = new();
                if (accountInput.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Try to import data
                        TransactionSet.Transactions.AddRange(FileImportClient.MonzoImport(fileDialog.FileName, accountInput.AccountName));
                        Client.UpdateTransactions(TransactionSet);
                        Home_Load(sender, e);
                    }
                    catch (FileImportException ex)
                    {
                        // Show error message
                        MessageBox.Show(Resource.Message.ImportError(ex), Resource.Message.IMPORT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                if (categoriseForm.ShowDialog() != DialogResult.OK)
                    break;
            }

            // Update database
            Client.UpdateTransactions(TransactionSet);

            // Reload form
            Home_Load(sender, e);
        }

        /// <summary>
        /// Open window with all transactions
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripViewAll_Click(object sender, EventArgs e)
        {
            TransactionView transactionView = new(TransactionSet.Transactions);
            transactionView.ShowDialog();
        }

        /// <summary>
        /// Open window with transactions totalled by account
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStrupViewTotalByAccount_Click(object sender, EventArgs e)
        {
            TotalBy totalByCategory = new(Resource.Literal.ACCOUNT, TransactionSet.Transactions);
            totalByCategory.ShowDialog();
        }

        /// <summary>
        /// Open window with transactions totalled by category
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripViewTotalByCategory_Click(object sender, EventArgs e)
        {
            TotalBy totalByCategory = new(Resource.Literal.CATEGORY, TransactionSet.Transactions);
            totalByCategory.ShowDialog();
        }

        /// <summary>
        /// Open window with transactions totalled by name
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripViewTotalByName_Click(object sender, EventArgs e)
        {
            TotalBy totalByCategory = new(Resource.Literal.NAME, TransactionSet.Transactions);
            totalByCategory.ShowDialog();
        }

        /// <summary>
        /// Open new query window
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeMenuStripQuery_Click(object sender, EventArgs e)
        {
            // Show query selector
            QuerySelector querySelector = new(
                TransactionSet.Transactions,
                TransactionSet.StartDate,
                TransactionSet.Accounts,
                TransactionSet.Categories,
                TransactionSet.MinAmount,
                TransactionSet.MaxAmount);

            // Show query in transaction view if ok
            if (querySelector.ShowDialog() == DialogResult.OK)
            {
                // Check if query has returned results
                if (querySelector.Transactions.Count > 0)
                {
                    TransactionView transactionView = new(querySelector.Transactions);
                    transactionView.Text = querySelector.Text;
                    transactionView.ShowDialog();
                }
                else
                    MessageBox.Show(Resource.Message.NOT_FOUND_TEXT, Resource.Message.NOT_FOUND, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Table

        /// <summary>
        /// Table cell click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void HomeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get cell data and show dialog if it contains 1 or more transaction
            CellData cellData = (CellData)HomeTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;
            if (cellData.Transactions.Count > 0)
            {
                TransactionView transactionView = new(cellData.Transactions);
                transactionView.Text = Resource.Message.CellExpansion(cellData.Category, cellData.Month, cellData.Total);
                transactionView.ShowDialog();
            }
        }

        /// <summary>
        /// Populate table
        /// </summary>
        /// <param name="TransactionSet">Transaction set</param>
        private void PopulateTable()
        {
            // Add month header
            HomeTable.Columns.Add(Resource.Literal.MONTH, Resource.Literal.MONTH);

            // Add category headers
            foreach (string? category in TransactionSet.Categories)
            {
                int categoryIndex = HomeTable.Columns.Add(category, category);
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Format = Resource.Argument.CURRENCY_FORMAT;
                HomeTable.Columns[categoryIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Add total header
            int totalIndex = HomeTable.Columns.Add(Resource.Literal.TOTAL, Resource.Literal.TOTAL);
            HomeTable.Columns[totalIndex].DefaultCellStyle.Format = Resource.Argument.CURRENCY_FORMAT;
            HomeTable.Columns[totalIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            HomeTable.Columns[totalIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Iterate through months
            List<DateTime> months = GetRowLabels(TransactionSet.StartDate);
            List<float> cellValues = new();
            foreach (DateTime month in months)
            {
                // Create new row
                DataGridViewRow newRow = new();
                CellData totalCellData = new(Resource.Literal.TOTAL, month);

                // Add date
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = month.ToString(Resource.Argument.MONTH_YEAR_DATE), Tag = month });

                // Add category totals
                foreach (string category in TransactionSet.Categories)
                {
                    // Create cell and add to row
                    CellData cellData = TransactionSet.GetCellData(month, category);
                    DataGridViewCell newCell = new DataGridViewTextBoxCell { Value = cellData.Transactions.Count != 0 ? cellData.Total : string.Empty, Tag = cellData };
                    newRow.Cells.Add(newCell);

                    // Add total to row total and month total list
                    totalCellData.Total += cellData.Total;
                    totalCellData.Transactions.AddRange(cellData.Transactions);
                    cellValues.Add(cellData.Total);
                }

                // Add total and add row to table
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = totalCellData.Total, Tag = totalCellData });
                cellValues.Add(totalCellData.Total);
                HomeTable.Rows.Add(newRow);
            }

            // Sort month total and colour cells
            cellValues.Sort();
            ColourCells(TransactionSet.Categories, new ColourCalculator(cellValues.First(), cellValues.Last()));

            // Colour total column
            ColourCells(new List<string> { Resource.Literal.TOTAL }, new ColourCalculator(cellValues.First(), cellValues.Last()));

            // Resize columns
            HomeTable.AutoResizeColumns();

            // Size form
            Width = HomeTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + Resource.Argument.DGV_MARGIN;
            Height = HomeTable.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + Resource.Argument.DGV_MARGIN;
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