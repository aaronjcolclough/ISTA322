using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
                timeOfDay = "Good Morning";
            else if (hour < 18)
                timeOfDay = "Good Afternoon";
            else
                timeOfDay = "Good Evening";
            ViewBag.Greeting = timeOfDay;
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error 
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where (r => r.WillAttend == true));
        }
    }
}
