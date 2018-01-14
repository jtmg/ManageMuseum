using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;
using Microsoft.Ajax.Utilities;

namespace ManageMuseum.Controllers
{
    public class LoginController : Controller
    {
        
        
        // GET: Login
        public ActionResult ConfirmLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConfirmLogin(UserAccount user)
        {
            string userName = user.Username;
            switch (userName)
            {
                case "manel":
                {
                    return RedirectToAction("Index","ExhibitionShedule");
                }
                case "igor":
                {
                    return RedirectToAction("Index", "SheduleEvent");
                    }
                 
            }
           

            return View();
        }
    }
}