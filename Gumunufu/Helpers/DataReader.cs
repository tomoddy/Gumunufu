using CsvHelper;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// Data reader
    /// </summary>
    internal class DataReader
    {
        /// <summary>
        /// Path
        /// </summary>
        private string Path { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="path">Path</param>
        internal DataReader(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Get transactions from database
        /// </summary>
        /// <returns>List of transactions</returns>
        internal List<Transaction> GetTransactions()
        {
            using StreamReader streamReader = new(Path);
            using CsvReader csvReader = new(streamReader, CultureInfo.InvariantCulture);
            csvReader.Context.RegisterClassMap<DataReaderMap>();
            return csvReader.GetRecords<Transaction>().ToList();
        }
    }
}