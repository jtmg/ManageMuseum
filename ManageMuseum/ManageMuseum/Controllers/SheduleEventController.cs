using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            

            var queryEventTypes = db.EventState.ToList();
            ViewBag.EventType = new SelectList(queryEventTypes,"Name","Name");

            var queryListSpaces = db.RoomMuseums.ToList();
            ViewBag.ListSpaces = new SelectList(queryListSpaces,"Id","Id");

            return View();
        }

       
        [HttpPost]
        public ActionResult SheduleEvent(EventViewModel events)
        {
            var eventType = events.EventType;
<<<<<<< HEAD
            var getEventTypeRow = db.EventTypes.FirstOrDefault(s => s.Name == eventType);
<<<<<<< HEAD
=======
>>>>>>> master
            var eventState = db.EventStates.Single(s => s.Id == 1);
=======
            var eventState = db.EventStates.Where(s => s.Id == 1).Single();
>>>>>>> parent of c2eff40... listar pedidos aceites
            var userId = Int32.Parse(Request.Cookies["UserId"].Value);
            var userAccount = db.UserAccounts.Include(d=>d.Role).FirstOrDefault(s => s.Id == userId);
            var finalEvent = new Event() {Name = events.Name, StartDate = events.StartDate, EnDate = events.EnDate,Description = events.Description,EventType = getEventTypeRow, EventState = eventState,UserAccount = userAccount};


            db.Events.Add(finalEvent);
            db.SaveChanges();



            return Content("hahahahaahahaha");
        }

    }
}