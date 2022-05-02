using Azure.Storage.Blobs;
using AzureStorage.Models;

namespace AzureStorage.Services;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobServiceClient;

    public BlobService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
    }

    public async Task<BlobInfo> GetBlobAsync(string name)
    {
        // var containerClient = _blobServiceClient.GetBlobContainerClient("mat-files");
        // var blobClient = containerClient.GetBlobClient(name);
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<string>> ListBlobsAsync()
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient("mat-files");
        var items = new List<string>();

        await foreach (var blobItem in containerClient.GetBlobsAsync())
        {
            items.Add(blobItem.Name);
        }

        return items;
    }
}