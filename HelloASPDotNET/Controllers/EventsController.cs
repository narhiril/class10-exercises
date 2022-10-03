using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloASPDotNET.Controllers
{
    public class EventsController : Controller
    {
        public static Dictionary<string, string> Events = new Dictionary<string, string>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult AddEvent(string eventName, string eventDesc)
        {
            Events.Add(eventName, eventDesc);
            return Redirect("/Events");
        }
    }
}
