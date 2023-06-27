using Microsoft.AspNetCore.Mvc;

namespace PirateGold.Controllers;

[ApiController]
[Route("[controller]")]
public class PhotoController : ControllerBase
{
    private readonly ILogger<PhotoController> _logger;

    public PhotoController(ILogger<PhotoController> logger)
    {
        _logger = logger;
    }
}