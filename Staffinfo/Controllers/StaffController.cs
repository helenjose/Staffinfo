﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Staffinfo.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult AddNewstaff(Models.StaffModel staff)
        {
            return View();
        }
    }
}