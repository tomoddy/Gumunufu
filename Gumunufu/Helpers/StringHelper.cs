using Gumunufu.Globals;
using Gumunufu.Helpers.DataImport;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Pase currency string to float
        /// </summary>
        /// <param name="value">Currency string</param>
        /// <param name="retVal">Returned float value</param>
        /// <returns>True if parsed, false otherwise</returns>
        internal static bool CurrencyParse(string value, out float retVal)
        {
            if (value.Equals(Resource.Argument.CURRENCY_DEFAULT))
            {
                retVal = 0;
                return true;
            }
            else
                return float.TryParse(value.Replace(Resource.Literal.COMMA, string.Empty).Replace(Resource.Literal.POUND, string.Empty).Replace(Resource.Literal.DOT, string.Empty).TrimStart(Resource.Character.ZERO), out retVal);
        }

        /// <summary>
        /// Checks regex of currency format
        /// </summary>
        /// <param name="text">Input text</param>
        /// <returns>True if valid, false otherwise</returns>
        internal static bool FormatIsValid(string text)
        {
            Regex money = new(Resource.Argument.CURRENCY_REGEX);
            return money.IsMatch(text);
        }
    }
}