using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OopMvcApplication.Models;

namespace OopMvcApplication.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult ProductList()
    {
        List<string> products = new()
            {
                "iPhone 15 Pro Max",
                "MacBook Air M3",
                "Apple Watch Series 9",
                "AirPods Pro 2"
            };

        ViewBag.Products = products;
        return View();
    }
}
