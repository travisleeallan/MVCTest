﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers;

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

    public IActionResult JSsample()
    {
        return View();
    }

    public IActionResult SliceofHeaven()
    {
        return View();
    }
    public IActionResult SideScroller()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
