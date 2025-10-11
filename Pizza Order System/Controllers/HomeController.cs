// Student: yuval matasaro, ID: 991735973

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pizza_Order_System.Models;
using Pizza_Order_System.Services;

namespace Pizza_Order_System.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPizzaOrderService _orderService;

    public HomeController(ILogger<HomeController> logger, IPizzaOrderService orderService)
    {
        _logger = logger;
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new OrderInputModel());
    }

    [HttpPost]
    public IActionResult Index(OrderInputModel input)
    {
        if (!ModelState.IsValid) return View(input);

        var receipt = _orderService.CalculateReceipt(input);
        return View("Receipt", receipt);
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
}