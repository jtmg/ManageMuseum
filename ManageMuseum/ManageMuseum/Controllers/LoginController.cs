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
            string password = user.Password;
            
            if (new UserManager().IsValid(userName, password))
            {
                var role = new UserManager().Role(userName, password);
                var userId = new UserManager().GetId(userName, password);

                switch (role)
                {
                    case 1:
                    {
                        //HttpCookie cookie = Request.Cookies["UserId"];
                        //if (!cookie.Values.ToString().Equals(userId.ToString()))
                        //{
                        //        cookie = new HttpCookie("UserId");
                        //    cookie.Values["UserId"] = userId.ToString();
                        //}



                        return RedirectToAction("SheduleEvent", "SheduleEvent");
                        }
                    case 2:
                        {
                            return RedirectToAction("Index", "ExhibitionShedule");
                        }
                }
            }

            return View();
        }
    }
}