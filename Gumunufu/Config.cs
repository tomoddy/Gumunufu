using System.Configuration;

namespace Gumunufu
{
    /// <summary>
    /// Config
    /// </summary>
    public static class Config
    {
        #region Methods

        /// <summary>
        /// Get config value using key
        /// </summary>
        /// <param name="key">Key of config value</param>
        /// <returns>Config value</returns>
        private static string Get(string key)
        {
            return new string(ConfigurationManager.AppSettings.Get(key));
        }

        /// <summary>
        /// Get config value using key
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="key">Key of config value</param>
        /// <param name="handler">Try parse for type</param>
        /// <returns>Config value</returns>
        private static T Get<T>(string key, TryParseHandler<T> handler)
        {
            if (handler(Get(key), out T retVal))
                return retVal;
            else
                throw new Exception($"Property with key \"{key}\" could not be found");
        }

        /// <summary>
        /// Try parse handler
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value">Value</param>
        /// <param name="result">Result</param>
        /// <returns>True if parsed, false otherwise</returns>
        private delegate bool TryParseHandler<T>(string value, out T result);

        #endregion

        #region Global Constants

        /// <summary>
        /// Date
        /// </summary>
        public const string DATE = "Date";

        /// <summary>
        /// Category
        /// </summary>
        public const string CATEGORY = "Category";

        /// <summary>
        /// Name
        /// </summary>
        public const string NAME = "Name";

        /// <summary>
        /// Amount
        /// </summary>
        public const string AMOUNT = "Amount";

        /// <summary>
        /// Month label
        /// </summary>
        public const string MONTH = "Month";

        /// <summary>
        /// Total label
        /// </summary>
        public const string TOTAL = "Total";

        /// <summary>
        /// Short date format
        /// </summary>
        public const string SHORT_DATE = "dd/MM/yyyy";

        /// <summary>
        /// Month/year date format
        /// </summary>
        public const string MONTH_YEAR_DATE = "MMM yyyy";

        /// <summary>
        /// Margin for resizing form
        /// </summary>
        public const int DGV_MARGIN = 200;

        /// <summary>
        /// CSV file dialog format
        /// </summary>
        public const string CSV_FILTER = "CSV Files (*.csv)|*.csv";

        /// <summary>
        /// Currency cell format
        /// </summary>
        public const string CURRENCY_FORMAT = "c2"; 

        /// <summary>
        /// Search query
        /// </summary>
        public const string SEARCH_QUERY = "https://www.google.com/search?q=";

        #endregion

        #region Config Options

        /// <summary>
        /// Icon path
        /// </summary>
        public static string Icon => Get("Icon");

        /// <summary>
        /// Database path
        /// </summary>
        public static string DatabasePath => Get("DatabasePath");

        /// <summary>
        /// Browser path
        /// </summary>
        public static string BrowserPath => Get("BrowserPath");

        /// <summary>
        /// Start date
        /// </summary>
        public static DateTime StartDate => Get<DateTime>("StartDate", DateTime.TryParse);

        /// <summary>
        /// Column order
        /// </summary>
        public static List<string> ColumnOrder => Get("ColumnOrder").Split(',').ToList();

        #endregion
    }
}