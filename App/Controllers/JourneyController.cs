using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public class JourneyController : Controller
{
    private readonly ILogger<JourneyController> _logger;

    public JourneyController(ILogger<JourneyController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
