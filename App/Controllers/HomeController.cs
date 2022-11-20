using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using System.Web;

namespace App.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string email)
    {
        return RedirectToAction("Index", "Journey");
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
