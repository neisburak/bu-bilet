using Business.Journey;
using Business.Journey.Dto.Param;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public class JourneyController : Controller
{
    private readonly IJourneyService _journeyService;

    public JourneyController(IJourneyService journeyService)
    {
        _journeyService = journeyService;
    }

    [HttpGet("/seferler/{originId}-{destinationId}/{departure}")]
    public async Task<IActionResult> Index(int originId, int destinationId, DateTime departure, CancellationToken cancellationToken)
    {
        var param = new LocationForJourney { OriginId = originId, DestinationId = destinationId, DepartureDate = departure.ToString("o") };

        var data = await _journeyService.GetAsync(param, cancellationToken);

        if (data.IsSuccess) return View(data.Data);
        return RedirectToAction("Error", "Home");
    }
}
