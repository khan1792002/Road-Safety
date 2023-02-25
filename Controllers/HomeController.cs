﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Road_Safety.Models;

namespace Road_Safety.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult RoadSafety()
    {
        return View();
    }

    public IActionResult TrafficSigns()
    {
        return View();
    }

    public IActionResult AccidentDetail()
    {
        return View();
    }

<<<<<<< HEAD
    public IActionResult NoOfCasualities()
=======
    public IActionResult Login()
>>>>>>> b5863124eb23dba7b0044c5e5df1cbbdb2fb53de
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
