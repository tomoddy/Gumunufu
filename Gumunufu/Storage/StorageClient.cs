using Gumunufu.Globals;
using Gumunufu.Storage.Csv;
using Gumunufu.Storage.Firebase;

namespace Gumunufu.Storage
{
    /// <summary>
    /// Storage client
    /// </summary>
    internal class StorageClient : StorageClientCreator
    {
        /// <summary>
        /// Create storage client
        /// </summary>
        /// <param name="type">Client type</param>
        /// <returns>Storage client</returns>
        /// <exception cref="ArgumentException">Invaild storage type</exception>
        public override IStorageClient CreateClient(StorageType type)
        {
            return type switch
            {
                StorageType.Csv => new CsvClient(Config.CsvPath),
                StorageType.Firebase => new FirebaseClient(Config.FirebaseKeyPath, Config.FirebaseDatabaseName, Config.FirebaseUsername),
                _ => throw new ArgumentException(type.ToString())
            };
        }
    }
}