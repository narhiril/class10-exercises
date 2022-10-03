using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloASPDotNET.Controllers
{
    public class EventsController : Controller
    {
        public static List<string> events = new List<string>();

        [HttpGet]
        public IActionResult Index()
        {
            events.Add("Halloween");
            events.Add("Rocket Launch");
            events.Add("Relatives Visiting");
            events.Add("LaunchCode");
            ViewBag.events = events;

            return View();
        }
    }
}
