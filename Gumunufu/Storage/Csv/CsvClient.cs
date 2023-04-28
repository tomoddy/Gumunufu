using CsvHelper;
using Gumunufu.Globals;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Storage.Csv
{
    /// <summary>
    /// Csv client
    /// </summary>
    public class CsvClient : IStorageClient
    {
        /// <summary>
        /// Path
        /// </summary>
        private string DatabasePath { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="databasePath">Path</param>
        internal CsvClient(string databasePath)
        {
            DatabasePath = databasePath;
        }

        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        public TransactionSet GetTransactions()
        {
            // Create reader
            using StreamReader streamReader = new(DatabasePath);
            using CsvReader csvReader = new(streamReader, CultureInfo.CurrentCulture);
            csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add(string.Empty);
            csvReader.Context.RegisterClassMap<CsvDataReaderMap>();

            // Read and return records
            return new TransactionSet(csvReader.GetRecords<Transaction>().ToList());
        }

        /// <summary>
        /// Update database
        /// </summary>
        /// <param name="transactionSet">Transaction set</param>
        public void UpdateTransactions(TransactionSet transactionSet)
        {
            // Copy database to new temp file
            string extension = Path.GetExtension(DatabasePath);
            string tempPath = $"{Path.ChangeExtension(DatabasePath, string.Empty)}{Resource.Argument.TEMP}{extension}";
            File.Copy(DatabasePath, tempPath);

            // Create writer
            using StreamWriter streamWriter = new(tempPath);
            using (CsvWriter csvWriter = new(streamWriter, CultureInfo.CurrentCulture))
            {
                csvWriter.Context.RegisterClassMap<CsvDataReaderMap>();
                csvWriter.WriteRecords(transactionSet.Transactions);
            }

            // Delete old database and rename new database
            File.Delete(DatabasePath);
            File.Move(tempPath, DatabasePath);
        }
    }
}