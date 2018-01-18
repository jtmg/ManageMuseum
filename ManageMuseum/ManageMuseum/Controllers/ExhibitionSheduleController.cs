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
    }
}