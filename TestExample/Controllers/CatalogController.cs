using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestExample.Repository;
using TestExample.Services;

namespace TestExample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatalogController : ControllerBase
{
    private readonly ILogger<CatalogController> _logger;
    public CatalogController(ILogger<CatalogController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Get file by name
    /// </summary>
    /// <param name="fileName">file name which user request in query</param>
    /// <returns>Requested file</returns>
    /// <remarks>
    ///         Request example:
    ///         Get /api/catalog?file="test.txt"
    /// </remarks>
    /// <response code="200">File content</response>
    /// <response code="400">If the file name is null</response>
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(string file)
    {
        return Ok(await new FileService().Request(file));
    }
    
    /// <summary>
    /// Get file by name
    /// </summary>
    /// <param name="fileName">file name which user request in query</param>
    /// <returns>Requested file</returns>
    /// <remarks>
    ///         Show in DEBUG GUID of response and file length
    ///         Request example:
    ///         Get /api/catalog/test?file="test.txt"
    /// </remarks>
    /// <response code="200">File content</response>
    /// <response code="400">If the file name is null</response>
    [Route("Test")]
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<IActionResult> Test(string file)
    {
        var result = await new FileService().Request(file);
        Debug.WriteLine($"Request: {Guid.NewGuid()} || {result}  || Response time: {DateTime.Now}");
        return Ok(result);
    }
}