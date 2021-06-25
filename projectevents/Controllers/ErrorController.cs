﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace projectevents.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Error()
        {
            HttpContext.Session.Clear();
            return View("Error");
        }
    }
}