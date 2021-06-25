using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectevents.Interfaces;
using projectevents.Library;
using projectevents.Models;

namespace projectevents.Controllers
{
    public class RegistrationController : Controller
    {
        IRegistration _IRepository;
        IRoles _IRoles;
        public RegistrationController(IRegistration IRepository, IRoles IRoles)
        {
            _IRepository = IRepository;
            _IRoles = IRoles;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Registration()
        {
            try
            {
                Registration Registration = new Registration();
                Registration.Country = null;
                Registration.City = null;
                Registration.State = null;
                return View(Registration);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(Registration Registration)
        {
            try
            {
                var isUsernameExists = _IRepository.CheckUserNameExists(Registration.Username);

                if (isUsernameExists)
                {
                    ModelState.AddModelError("", errorMessage: "Username Already Used try unique one!");
                }
                else
                {
                    Registration.CreatedOn = DateTime.Now;
                    Registration.RoleID = _IRoles.getRolesofUserbyRolename("Users");
                    Registration.Password = EncryptionLibrary.EncryptText(Registration.Password);
                    Registration.ConfirmPassword = EncryptionLibrary.EncryptText(Registration.ConfirmPassword);
                    if (_IRepository.AddUser(Registration) > 0)
                    {
                        TempData["MessageRegistration"] = "Data Saved Successfully!";
                        return View();
                    }
                    else
                    {
                        return View(Registration);
                    }
                }

                return View(Registration);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public JsonResult CheckUserNameExists(string Username)
        {
            try
            {
                var isUsernameExists = _IRepository.CheckUserNameExists(Username);
                if (isUsernameExists)
                {
                    return Json(data: true);
                }
                else
                {
                    return Json(data: false);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public string getotp(string MobileNo12)
        {

          //  HttpContext.Session.SetString("otp", null);
            string numbers = "1234567890";

            string characters = numbers;
            string otp = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }
          
          HttpContext.Session.SetString("otp", "123456");
            string result = "success"; //sendSMS(otp, MobileNo12);
            if (result.Contains("success"))
            {
                result = "OTP sent successfully";
            }
            return result;


        }
        [HttpPost]
        public string Varify(string OTP)
        {
           string x= HttpContext.Session.GetString("otp");
            if (HttpContext.Session.GetString("otp") != null)
            {
                if (HttpContext.Session.GetString("otp").ToString() == OTP)
                {
                    HttpContext.Session.SetString("otp",string.Empty);
                    return "Varify";

                }
                else
                {
                    return "OTP entered by you is incorrect. Please try again or click GET OTP to get a new OTP.";
                }
            }
            else
            {
                return "";
            }



        }
    }
}