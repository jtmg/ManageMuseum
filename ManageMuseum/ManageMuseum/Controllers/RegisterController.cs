using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;

namespace ManageMuseum.Controllers
{
    public class RegisterController : Controller
    {
        private OurContectDb db = new OurContectDb();
        public ActionResult Register()
        {
            var roles = db.Roles.ToList();
            ViewBag.Roles = new SelectList(roles,"Name","Name");
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel userAccount)
        {
            

            return View();
        }
    }
}