using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageMuseum.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Login()
        {
            return View("~/Views/Login/Login.cshtml");
        }
    }
}