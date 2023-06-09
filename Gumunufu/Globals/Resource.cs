﻿namespace Gumunufu.Globals
{
    /// <summary>
    /// Global constants
    /// </summary>
    public static class Resource
    {
        /// <summary>
        /// String literals
        /// </summary>
        public static class Literal
        {
            /// <summary>
            /// Project name
            /// </summary>
            public const string GUNUFUFU = "GUMUFUNU";

            /// <summary>
            /// Date
            /// </summary>
            public const string DATE = "Date";

            /// <summary>
            /// Account
            /// </summary>
            public const string ACCOUNT = "Account";

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
            /// Comma
            /// </summary>
            public const string COMMA = ",";

            /// <summary>
            /// Pound sign
            /// </summary>
            public const string POUND = "£";

            /// <summary>
            /// Dot
            /// </summary>
            public const string DOT = ".";
        }

        /// <summary>
        /// Characters
        /// </summary>
        public static class Character
        {
            /// <summary>
            /// Space
            /// </summary>
            public const char SPACE = ' ';

            /// <summary>
            /// Plus
            /// </summary>
            public const char PLUS = '+';

            /// <summary>
            /// Zero
            /// </summary>
            public const char ZERO = '0';
        }

        /// <summary>
        /// Messages
        /// </summary>
        public static class Message
        {
            /// <summary>
            /// Import error
            /// </summary>
            public const string UNKNOWN_ERROR = "Unknown Error";

            /// <summary>
            /// Import error
            /// </summary>
            public const string IMPORT_ERROR = "Import Error";

            /// <summary>
            /// Import error
            /// </summary>
            /// <param name="ex">Exception</param>
            /// <returns>Text</returns>
            public static string ImportError(Exception ex)
            {
                return $"Data from file could not be imported.\n{ex.Message}";
            }

            /// <summary>
            /// Categorise text
            /// </summary>
            public const string CATEGORISE = "Categorise";

            /// <summary>
            /// Categorise text
            /// </summary>
            /// <param name="count">Number of transactions</param>
            /// <returns>Text</returns>
            public static string Categorise(int count)
            {
                return $"{CATEGORISE} ({count})";
            }

            /// <summary>
            /// Cell expansion text
            /// </summary>
            /// <param name="category">Category</param>
            /// <param name="month">Month</param>
            /// <param name="total">Total</param>
            /// <returns>Text</returns>
            internal static string CellExpansion(string category, DateTime month, float total)
            {
                return $"{category} in {month.ToString(Argument.MONTH_YEAR_DATE)} ({total.ToString(Argument.CURRENCY_FORMAT)})";
            }

            /// <summary>
            /// Query not found
            /// </summary>
            public const string NOT_FOUND = "No Results";

            /// <summary>
            /// Query not found text
            /// </summary>
            public const string NOT_FOUND_TEXT = "Query returned no results.";

            /// <summary>
            /// Add transaction
            /// </summary>
            public const string ADD_TRANSACTION = "Add Transaction";

            /// <summary>
            /// Edit transaction
            /// </summary>
            public const string EDIT_TRANSACTION = "Edit Transaction";

            /// <summary>
            /// Exception message for message box
            /// </summary>
            /// <param name="ex">Exception</param>
            /// <returns>Text</returns>
            public static string ExceptionMessage(Exception ex)
            {
                return $"{ex.GetType()} : {ex.Message}";
            }
        }

        /// <summary>
        /// Arguments
        /// </summary>
        public static class Argument
        {
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
            /// Locale
            /// </summary>
            public const string LOCALE = "en-GB";

            /// <summary>
            /// Currency cell format for text box
            /// </summary>
            public const string CURRENCY_FORMAT_INPUT = "{0:C2}";

            /// <summary>
            /// Currency default
            /// </summary>
            public const string CURRENCY_DEFAULT = "£0.00";

            /// <summary>
            /// Currency cell format
            /// </summary>
            public const string TEMP = "Temp";

            /// <summary>
            /// Search query
            /// </summary>
            public const string SEARCH_QUERY = "https://www.google.com/search?q=";

            /// <summary>
            /// Currency regex
            /// </summary>
            public const string CURRENCY_REGEX = @"^\£(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$";

            /// <summary>
            /// Home menu strip categorise
            /// </summary>
            public const string STRIP_CATEGORISE = "HomeMenuStripCategorise";
        }

        /// <summary>
        /// Firebase strings
        /// </summary>
        public static class Firebase
        {
            /// <summary>
            /// Google applications credentials
            /// </summary>
            public const string GOOGLE_APPLICATION_CREDENTIALS = "GOOGLE_APPLICATION_CREDENTIALS";

            /// <summary>
            /// Users
            /// </summary>
            public const string USERS = "Users";

            /// <summary>
            /// Accounts
            /// </summary>
            public const string ACCOUNTS = "Accounts";

            /// <summary>
            /// Username
            /// </summary>
            public const string USERNAME = "Username";

            /// <summary>
            /// Password
            /// </summary>
            public const string PASSWORD = "Password";

            /// <summary>
            /// TransactionSets
            /// </summary>
            public const string TRANSACTION_SETS = "TransactionSets";

            /// <summary>
            /// Transactions
            /// </summary>
            public const string TRANSACTIONS = "Transactions";
        }
    }
}
