namespace Gumunufu.Helpers.DataImport
{
    /// <summary>
    /// String not found exception
    /// </summary>
    [Serializable]
    internal class FileImportException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FileImportException() { }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="message">Message</param>
        public FileImportException(string message) : base(message) { }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="inner">Inner exception</param>
        public FileImportException(string message, Exception inner) : base(message, inner) { }
    }
}