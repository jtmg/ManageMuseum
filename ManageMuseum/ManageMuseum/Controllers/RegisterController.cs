﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageMuseum.Models;

namespace ManageMuseum.Controllers
{
    public class RegisterController : Controller
    {
        private string[] roles = {"Art piece manager","space manager"}; 
        public ActionResult Register()
        {
            ViewBag.Roles = new SelectList(roles);
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount userAccount)
        {
            ViewBag.Roles = new SelectList(roles);
            return Content("MIrone");
        }
    }
}