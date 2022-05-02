using AzureStorage.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureStorage.Controllers; 

[ApiController]
[Route("[controller]")]
public class BlobExplorerController : ControllerBase
{
    private readonly IBlobService _blobService;

    public BlobExplorerController(IBlobService blobService)
    {
        _blobService = blobService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _blobService.ListBlobsAsync());
    }
}