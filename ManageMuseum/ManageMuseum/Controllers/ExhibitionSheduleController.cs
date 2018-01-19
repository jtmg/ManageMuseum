using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;

namespace ManageMuseum.Controllers
{
    public class ExhibitionSheduleController : Controller
    {
        private OurContectDb db = new OurContectDb();
        // GET: ExhibitionShedule
        public ActionResult SheduleExhibition()
        {
            var queryEventTypes = db.EventTypes.ToList();
            ViewBag.EventType = new SelectList(queryEventTypes, "Name", "Name");

            var queryListSpaces = db.RoomMuseums.ToList();
            ViewBag.ListSpaces = new SelectList(queryListSpaces, "Id", "Id");
            return View();
        }


        public ActionResult ShowRequestsList()
        {
            var db = new OurContectDb();

            var query = db.Events.Include(d => d.EventState).Include(d => d.EventType).Where(d => d.EventState.Id == 1).ToList();
            ViewBag.Data = query;
            return View();
        }

        public ActionResult EventRequestApprove()
        {
            return Content("Aprovar pedido");
        }

        public ActionResult EventRequestDetails(string eventId)
        {
            var EventIdSelected = Int32.Parse(eventId);
            ViewData["EventIdSelected"] = EventIdSelected;
            return View();
        }
    }
}