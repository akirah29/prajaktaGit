﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGitDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //This is from Master
            return View();
        }
        //comment
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}