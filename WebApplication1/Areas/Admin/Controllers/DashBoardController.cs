﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashBoardController : Controller
    { 
        // GET: Admin/DashBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}