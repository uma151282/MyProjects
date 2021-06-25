using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace projectevents.Controllers
{
    public class welcomeController : Controller
    {
        //[Route("Walkin3/Welcome/{city}/{location}")]
        public IActionResult Index(string city,string location)
        {
            string cityy = city;
            string locations = location;
            return View();
        }
    }
}