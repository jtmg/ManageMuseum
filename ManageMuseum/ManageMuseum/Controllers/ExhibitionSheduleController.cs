﻿using System;
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
            var query = db.Events.Include(d => d.EventState).Include(d => d.EventType).Where(d => d.EventState.Id == 1).ToList();
            ViewBag.Data = query;
            return View();
        }

        public ActionResult EventRequestApprove(string eventId)
        {
            var EventIdApprove = Int32.Parse(eventId);

            EventState approvedState = db.EventStates.First(d => d.Name == "aceites");
            
            Event update = db.Events.Include(v => v.EventState).First(d => d.Id == EventIdApprove);
            update.EventState = approvedState;
            db.SaveChanges();
            //FALTA COLOCAR AQUI UMA MENSAGEM DE AVISO QUE O PEDIDO DE EVENTO FOI APROVADO
            return Redirect("ShowRequestsList");
        }

        public ActionResult EventRequestDetails(string eventId)
        {
            var EventIdSelected = Int32.Parse(eventId);

            var queryEventDetails = db.Events.Include(d=>d.UserAccount).Include(d => d.EventState).Include(d => d.EventType).Single(s => s.Id == EventIdSelected);
            ViewBag.evento = queryEventDetails;
            ViewData["EventUserId"] = queryEventDetails.UserAccount.Id;
            ViewData["EventUserFName"] = queryEventDetails.UserAccount.FirstName;
            ViewData["EventUserLName"] = queryEventDetails.UserAccount.LastName;
            ViewData["EventSelected"] = queryEventDetails.Id;
            ViewData["EventName"] = queryEventDetails.Name;
            ViewData["EventType"] = queryEventDetails.EventType.Name;
            ViewData["EventStartDate"] = queryEventDetails.StartDate;
            ViewData["EventEndDate"] = queryEventDetails.EnDate;
            ViewData["EventDescription"] = queryEventDetails.Description;

            return View();
        }
    }
}
//var queryEventDetails = db.Events.Include(d => d.UserAccount).Include(d => d.EventState).Include(d => d.EventType).Where(s => s.Id == EventIdSelected).ToList();