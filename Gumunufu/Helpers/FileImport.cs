using Gumunufu.Objects;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// Importing bank statements
    /// </summary>
    internal class FileImport
    {
        /// <summary>
        /// Import from lloyds bank statement
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>List of transactions</returns>
        internal static List<Transaction> LloydsImport(string path)
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
                    Date = DateTime.Parse(cells[0]),
                    Name = cells[4],
                    Amount = credit - debit
                });
            }

            // Return list
            return retVal;
        }
    }
}