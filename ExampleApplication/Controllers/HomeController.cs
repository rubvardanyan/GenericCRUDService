﻿using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExampleApplication.Models;
namespace ExampleApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About(int id)
        {
            ViewData["Message"] = String.Format("Just Testing MVC. ID: {0}.", id);

            return View();
        }
        
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}