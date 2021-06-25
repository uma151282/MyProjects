using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectevents.Filters;
using projectevents.Interfaces;

namespace projectevents.Controllers
{
    //[ValidateUserSession]
    [Authorize(Roles = "Customer")]
    public class UserProfileController : Controller
    {
        IRegistration _IRepository;
        public UserProfileController(IRegistration IRepository)
        {
            _IRepository = IRepository;
        }

        [HttpGet]
        public IActionResult Profile()
        {
            try
            {
                var profile = _IRepository.Userinformation(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                return View(profile);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}