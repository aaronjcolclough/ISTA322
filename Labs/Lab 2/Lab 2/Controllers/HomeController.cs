using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_2.Models;

namespace Lab_2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
            {
                timeOfDay = "Good Morning";
            }
            else if (hour < 18)
            {
                timeOfDay = "Good Afternoon";
            }
            else
            {
                timeOfDay = "Good Evening";
            }
            ViewBag.Greeting = timeOfDay;
            return View("MyView");
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

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
