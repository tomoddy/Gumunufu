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
        /// <summary>
        /// Default constructor
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Home_Load(object sender, EventArgs e)
        {
            DataReader reader = new("Database.csv");
            TransactionSet transactionSet = new(reader.GetTransactions());
            PopulateTable(transactionSet);
        }

        /// <summary>
        /// Populate table
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        private void PopulateTable(TransactionSet transactionSet)
        {
            // Add month header
            HomeTable.Columns.Add("Month", "Month");

            // Add category headers
            foreach (string? category in transactionSet.Categories)
            {
                int categoryIndex = HomeTable.Columns.Add(category, category);
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Format = "c2";
                HomeTable.Columns[categoryIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
                HomeTable.Columns[categoryIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Add total header
            int totalIndex = HomeTable.Columns.Add("Total", "Total");
            HomeTable.Columns[totalIndex].DefaultCellStyle.Format = "c2";
            HomeTable.Columns[totalIndex].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            HomeTable.Columns[totalIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Iterate through months
            List<DateTime> months = GetRowLabels(Config.StartDate);
            foreach (DateTime month in months)
            {
                // Create new row
                DataGridViewRow newRow = new();
                float total = 0;

                // Add date
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = month.ToString("MMM yyyy"), Tag = month });

                // Add category totals
                foreach (string category in transactionSet.Categories)
                {
                    CellData cellData = transactionSet.GetCellData(month, category);
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cellData.Total, Tag = cellData.Transactions });
                    total += cellData.Total;
                }

                // Add total and add row to table
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = total });
                HomeTable.Rows.Add(newRow);
            }

            // Resize columns
            HomeTable.AutoResizeColumns();
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
    }
}