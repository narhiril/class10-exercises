using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CodingEvents.Models;
using CodingEvents.Data;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        public static List<Event> Events = new List<Event>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult AddEvent(Event newEvent)
        {
            EventData.Add(newEvent);
            return Redirect("/Events");
        }

        [HttpGet]
        [Route("Events/Delete")]
        public IActionResult Delete()
        {
            ViewBag.Events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("Events/Delete")]
        public IActionResult Delete(int[] ids)
        {
            foreach (int id in ids)
            {
                EventData.Remove(id);
            }

            return Redirect("/Events");
        }

        [HttpGet]
        [Route("Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            ViewBag.Selected = EventData.GetById(eventId);
            ViewBag.EditTitle = $"Edit Event '{ViewBag.Selected.Name}' (ID = {eventId})";
            return View();
        }

        [HttpPost]
        [Route("Events/Edit/{eventId}")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            Event toBeEdited = EventData.GetById(eventId);
            toBeEdited.Name = name;
            toBeEdited.Description = description;
            return Redirect("/Events");
        }
    }
}
