﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Retail Reports POC";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reports()
        {
            ViewData["Message"] = "Acosta Reports.";

            return View();
        }
        public IActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
