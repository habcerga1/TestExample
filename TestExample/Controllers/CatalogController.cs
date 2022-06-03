using Microsoft.AspNetCore.Mvc;

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

    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}