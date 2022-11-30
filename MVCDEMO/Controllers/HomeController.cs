using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDEMO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDEMO.Controllers
{
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
            ViewData["message"] = "This is viewdata examle";
            ViewData["name"] = "Pradnya";
            ViewData["Per"] = 87.25;

            List<string> color = new List<string>()
            {
                "Red","Green","Black","white"
            };
            ViewData["color"] = color;


            ViewBag.Username = "Veda";
            ViewBag.Email = "veda1@gmail.com";
            ViewBag.color = color;
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult ContactUs()
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
