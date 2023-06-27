using Microsoft.AspNetCore.Mvc;

namespace PirateGold.Controllers;

[ApiController]
[Route("[controller]")]
public class CartridgePublisherController : ControllerBase
{
    private readonly ILogger<CartridgePublisherController> _logger;

    public CartridgePublisherController(ILogger<CartridgePublisherController> logger)
    {
        _logger = logger;
    }
}