using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "Welcome to the Home Page!";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        string aboutInfo = "This is a sample ASP.NET Core MVC application.";
        return View();
    }

    public IActionResult Contact()
    {
        string contactEmail = "hgjh@g.com";
        string message = "Contact us at " + contactEmail;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    ~HomeController()
    {
        Console.WriteLine("HomeController is being destroyed");
    }
}
