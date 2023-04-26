using CsvHelper;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// Data reader
    /// </summary>
    internal class DataClient
    {
        /// <summary>
        /// Path
        /// </summary>
        private string DatabasePath { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="databasePath">Path</param>
        internal DataClient(string databasePath)
        {
            DatabasePath = databasePath;
        }

        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        internal List<Transaction> GetTransactions()
        {
            // Create reader
            using StreamReader streamReader = new(DatabasePath);
            using CsvReader csvReader = new(streamReader, CultureInfo.CurrentCulture);
            csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("");
            csvReader.Context.RegisterClassMap<DataReaderMap>();

            // Read and return records
            return csvReader.GetRecords<Transaction>().ToList();
        }

        /// <summary>
        /// Update database
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        internal void UpdateTransactions(TransactionSet transactionSet)
        {
            // Copy database to new temp file
            string extension = Path.GetExtension(DatabasePath);
            string tempPath = $"{Path.ChangeExtension(DatabasePath, string.Empty)}Temp{extension}";
            File.Copy(DatabasePath, tempPath);

            // Create writer
            using StreamWriter streamWriter = new(tempPath);
            using (CsvWriter csvWriter = new(streamWriter, CultureInfo.CurrentCulture))
            {
                csvWriter.Context.RegisterClassMap<DataReaderMap>();
                csvWriter.WriteRecords(transactionSet.Transactions);
            }

            // Delete old database and rename new database
            File.Delete(DatabasePath);
            File.Move(tempPath, DatabasePath);
        }
    }
}