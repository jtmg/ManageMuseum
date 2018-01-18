using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;

namespace ManageMuseum.Controllers
{
    public class SheduleEventController : Controller
    {
        private OurContectDb db = new OurContectDb();
        // GET: SheduleEvent
        public ActionResult SheduleEvent()
        {
            

            var queryEventTypes = db.EventTypes.ToList();
            ViewBag.EventType = new SelectList(queryEventTypes,"Name","Name");

            var queryListSpaces = db.RoomMuseums.ToList();
            ViewBag.ListSpaces = new SelectList(queryListSpaces,"Id","Id");

            return View();
        }

       
        [HttpPost]
        public ActionResult SheduleEvent(EventViewModel events)
        {
            var eventType = events.EventType;
            var getEventTypeRow = db.EventTypes.FirstOrDefault(s => s.Name == eventType);
            var getEventTypeid = getEventTypeRow.Id;
            var insertEventType = new EventType(){Name = events.EventType, Id = getEventTypeid};
            var eventState = new EventState(){Name = "poraprovar",Id = 1};
            var userId = Request.Cookies["UserId"];
            var finalEvent = new Event() {Name = events.Name, StartDate = events.StartDate, EnDate = events.EnDate,Description = events.Description,EventType = insertEventType,EventState = eventState};

            db.Events.Add(finalEvent);
            db.SaveChanges();



            return View();
        }

    }
}