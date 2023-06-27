using Microsoft.AspNetCore.Mvc;

namespace PirateGold.Controllers;

[ApiController]
[Route("[controller]")]
public class RomController : ControllerBase
{
    private readonly ILogger<RomController> _logger;

    public RomController(ILogger<RomController> logger)
    {
        _logger = logger;
    }
}