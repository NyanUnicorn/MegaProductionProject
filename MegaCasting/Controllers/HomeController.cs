using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MegaCasting.Models;
using MegaCasting.Models.Pages;

namespace MegaCasting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Page page = new Page_Index();
            return View(page);
        }

        public IActionResult Castings()
        {
            Page page = new Page_Casting();
            return View(page);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
