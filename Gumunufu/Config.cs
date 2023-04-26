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

        /// <summary>
        /// Icon path
        /// </summary>
        public static string Icon => Get("Icon");

        /// <summary>
        /// Database path
        /// </summary>
        public static string Path => Get("Path");

        /// <summary>
        /// Start date
        /// </summary>
        public static DateTime StartDate => Get<DateTime>("StartDate", DateTime.TryParse);

        /// <summary>
        /// Column order
        /// </summary>
        public static List<string> ColumnOrder => Get("ColumnOrder").Split(',').ToList();
    }
}