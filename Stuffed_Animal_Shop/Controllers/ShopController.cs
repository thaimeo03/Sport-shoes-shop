﻿using Microsoft.AspNetCore.Mvc;
using Stuffed_Animal_Shop.Models;
using System.Diagnostics;

namespace Stuffed_Animal_Shop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route("/shop/detail/{productId}")]
        public IActionResult Detail([FromRoute] string productId)
        {
            //Console.WriteLine(productId);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
