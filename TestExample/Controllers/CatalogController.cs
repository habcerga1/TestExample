using Microsoft.AspNetCore.Mvc;
using TestExample.Repository;
using TestExample.Services;

namespace TestExample.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogController : ControllerBase
{
    private readonly ILogger<CatalogController> _logger;

    public CatalogController(ILogger<CatalogController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Get(string file)
    {
        await new FileService().Request(file);
        return Ok();
    }
}