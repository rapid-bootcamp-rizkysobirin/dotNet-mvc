using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ContactUS()
    {
        return View();
    }

    public IActionResult AboutUS()
    {
        return View();
    }
    
    public IActionResult Admin()
    {
        return View();
    }
    
    public IActionResult Request()
    {
        return View();
    }
    public IActionResult Talent()
    {
        return View();
    }
    public IActionResult Asset()
    {
        return View();
    }
    public IActionResult Audit()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}