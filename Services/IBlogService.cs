using AzureStorage.Models;

namespace AzureStorage.Services;
public interface IBlobService {
    Task<BlobInfo> GetBlobAsync(string name);
    Task<IEnumerable<string>> ListBlobsAsync();
}