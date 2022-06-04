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
}