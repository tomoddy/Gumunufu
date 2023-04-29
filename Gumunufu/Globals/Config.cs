using System.Configuration;

namespace Gumunufu.Globals
{
    /// <summary>
    /// Config
    /// </summary>
    public static class Config
    {
#pragma warning disable IDE0051
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

        #region Config Options

        /// <summary>
        /// Icon path
        /// </summary>
        public static string Icon => Get("Icon");

        /// <summary>
        /// Storage type
        /// </summary>
        public static string StorageType => Get("StorageType");

        /// <summary>
        /// Database path
        /// </summary>
        public static string CsvPath => Get("CsvPath");

        /// <summary>
        /// Firebase key path
        /// </summary>
        public static string FirebaseKeyPath => Get("FirebaseKeyPath");

        /// <summary>
        /// Firebase database name
        /// </summary>
        public static string FirebaseDatabaseName => Get("FirebaseDatabaseName");

        /// <summary>
        /// Firebase username
        /// </summary>
        public static string FirebaseUsername => Get("FirebaseUsername");

        /// <summary>
        /// Firebase password
        /// </summary>
        public static string FirebasePassword => Get("FirebasePassword");

        /// <summary>
        /// Browser path
        /// </summary>
        public static string BrowserPath => Get("BrowserPath");

        /// <summary>
        /// Default account name
        /// </summary>
        public static string DefaultAccount => Get("DefaultAccount");

        #endregion
#pragma warning restore IDE0051
    }
}