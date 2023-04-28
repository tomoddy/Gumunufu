namespace Gumunufu.Storage
{
    /// <summary>
    /// Storage client creator
    /// </summary>
    internal abstract class StorageClientCreator
    {
        /// <summary>
        /// Create storage client
        /// </summary>
        /// <param name="type">Client type</param>
        /// <returns>Storage client</returns>
        public abstract IStorageClient CreateClient(StorageType type);
    }
}