using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje.Models;

namespace Proje.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string welcomeMessage = "Welcome.. Welcome..";
        ViewBag.Message = welcomeMessage;
        ViewBag.FirstName = "Memed";
        ViewBag.Day = "46";
        ViewBag.IsActive = true;
        return View();
    }

    
    public IActionResult Privacy()
    {
        List<Product> products = new List<Product>{
            new Product {Id=1, Name="iPhone 13", Price = 34500},
            new Product {Id=2, Name="Monster Tulpar", Price = 32500},
            new Product {Id=3, Name="Samsung Galaxy", Price = 24500},
            new Product {Id=4, Name="Dell XPs", Price = 14500},
            new Product {Id=5, Name="Apple Watch", Price = 9500},
            new Product {Id=6, Name="Sony PlayStation 5", Price = 19500}
        };
        // List<Product> products = new List<Product>{};
        ViewBag.ProductList = products;
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

}
