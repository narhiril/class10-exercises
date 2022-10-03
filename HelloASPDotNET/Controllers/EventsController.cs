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
            ViewBag.events = events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult AddEvent(string eventName)
        {
            events.Add(eventName);
            return Redirect("/Events");
        }
    }
}
