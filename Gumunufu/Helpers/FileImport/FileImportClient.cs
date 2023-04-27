using Gumunufu.Objects;

namespace Gumunufu.Helpers.FileImport
{
    /// <summary>
    /// Importing bank statements
    /// </summary>
    internal static class FileImportClient
    {
        /// <summary>
        /// Import from lloyds bank statement
        /// </summary>
        /// <param name="path">File path</param>
        /// <param name="accountName">Account name</param>
        /// <returns>List of transactions</returns>
        internal static List<Transaction> LloydsImport(string path, string accountName)
        {
            try
            {
                // Read file and remove first line
                List<Transaction> retVal = new();
                List<string> lines = File.ReadAllLines(path).ToList();
                lines.RemoveAt(0);

                // Add cells to line
                foreach (string line in lines)
                {
                    // Get cells and parse currency values
                    List<string> cells = line.Split(',').ToList();
                    _ = float.TryParse(cells[5], out float debit);
                    _ = float.TryParse(cells[6], out float credit);

                    // Add transaction to list
                    retVal.Add(new Transaction
                    {
                        Account = accountName,
                        Date = DateTime.Parse(cells[0]),
                        Name = cells[4],
                        Amount = credit - debit
                    });
                }

                // Return list
                return retVal;
            }
            catch (Exception ex)
            {
                // Throw generic exception
                throw new FileImportException("Import failed", ex);
            }
        }

        /// <summary>
        /// Import from monzo bank statement
        /// </summary>
        /// <param name="path">File path</param>
        /// <param name="accountName">Account name</param>
        /// <returns>List of transactions</returns>
        internal static List<Transaction> MonzoImport(string path, string accountName)
        {
            try
            {
                // Read file and remove first line
                List<Transaction> retVal = new();
                List<string> lines = File.ReadAllLines(path).ToList();
                lines.RemoveAt(0);

                // Add cells to line
                foreach (string line in lines)
                {
                    // Get cells and parse currency values
                    List<string> cells = line.Split(',').ToList();
                    _ = float.TryParse(cells[16], out float debit);
                    _ = float.TryParse(cells[17], out float credit);

                    // Add transaction to list
                    retVal.Add(new Transaction
                    {
                        Account = accountName,
                        Date = DateTime.Parse(cells[1]),
                        Name = StringHelper.FindFirstNonNullOrEmpty(new List<string> { cells[14], cells[4], cells[11] }),
                        Amount = credit + debit
                    });
                }

                // Return list
                return retVal;
            }
            catch (FileImportException ex)
            {
                // Throw specific exception
                throw ex;
            }
            catch (Exception ex)
            {
                // Throw generic exception
                throw new FileImportException("Import failed", ex);
            }
        }
    }
}