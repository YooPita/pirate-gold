using Microsoft.AspNetCore.Mvc;
using PirateGold.DataBase;

namespace PirateGold.Controllers;

[ApiController]
[Route("[controller]")]
public class CartridgeController : ControllerBase
{
    private readonly ILogger<CartridgeController> _logger;
    private readonly PirateGoldDbContext _context;

    public CartridgeController(
        ILogger<CartridgeController> logger,
        PirateGoldDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    //[HttpGet(Name = "GetCartridges")]
    //public async Task<IActionResult> Get()
    //{

    //}

}