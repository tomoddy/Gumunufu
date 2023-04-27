using Gumunufu.Helpers.FileImport;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// String helper methods
    /// </summary>
    internal static class StringHelper
    {
        /// <summary>
        /// Find first string in list of strings that is not null or empty
        /// </summary>
        /// <param name="testValues">List of values</param>
        /// <returns>Non null/empty string</returns>
        /// <exception cref="FileImportException">Not strings found</exception>
        internal static string FindFirstNonNullOrEmpty(List<string> testValues)
        {
            // Check if list contains values, otherwise throw exception
            if (testValues.Count > 0)
            {
                // Return if value is non null
                if (!string.IsNullOrEmpty(testValues.First()))
                    return testValues.First();

                // Remove value and recall method
                testValues.Remove(testValues.First());
                return FindFirstNonNullOrEmpty(testValues);
            }
            else
                throw new FileImportException();
        }
    }
}