using Microsoft.AspNetCore.Mvc;

namespace PirateGold.Controllers;

[ApiController]
[Route("[controller]")]
public class CartridgeTypeController : ControllerBase
{
    private readonly ILogger<CartridgeTypeController> _logger;

    public CartridgeTypeController(ILogger<CartridgeTypeController> logger)
    {
        _logger = logger;
    }
}