﻿using Microsoft.AspNetCore.Mvc;
using Stuffed_Animal_Shop.Models;
using System.Diagnostics;

namespace Stuffed_Animal_Shop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
