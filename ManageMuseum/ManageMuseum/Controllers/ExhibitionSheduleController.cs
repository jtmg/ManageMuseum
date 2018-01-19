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
        // GET: ExhibitionShedule
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRequestsList()
        {
            var db = new OurContectDb();

            var query = db.Events.Include(d => d.EventState).Include(d => d.EventType).Where(d => d.EventState.Id == 1);
            ViewBag.Data =  query;
            return View();
        }

        public ActionResult EventRequestApprove()
        {
            return Content("Aprovar pedido");
        }
       
        public ActionResult EventRequestDetails(string EventId)
        {
            var EventIdSelected = Int32.Parse(EventId);
            ViewData["EventIdSelected"] = EventIdSelected;
            return View();
        }

        //public ActionResult listaQUalquercoisa()
        //{
            
        //}

    }
}


//
//var eventDetails = Int32.Parse(collection["Events.Id"]);
//if (eventDetails != null)
//{
//    Event evento = new Event();

//    evento.Id = eventDetails.Id;
//    evento.Name = eventDetails.Name;
//    evento.Description = eventDetails.Description;
//    evento.EventType = eventDetails.EventType;
//    evento.StartDate = eventDetails.StartDate;
//    evento.EnDate = eventDetails.EnDate;
//    ViewData.Model = evento;

//}
//return View(a);