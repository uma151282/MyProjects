using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectevents.Interfaces;
using projectevents.Library;
using projectevents.Models;

namespace projectevents.Controllers
{
    public class LoginController : Controller
    {
        ILogin _ILogin;

        public LoginController(ILogin ILogin)
        {
            _ILogin = ILogin;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {

            try
            {
                if (!string.IsNullOrEmpty(loginViewModel.Username) && !string.IsNullOrEmpty(loginViewModel.Password))
                {
                    var Username = loginViewModel.Username;
                    var password = EncryptionLibrary.EncryptText(loginViewModel.Password);

                    var result = _ILogin.ValidateUser(Username, password);

                    if (result != null)
                    {
                        if (result.ID == 0 || result.ID < 0)
                        {
                            ViewBag.errormessage = "Entered Invalid Username and Password";
                        }
                        else
                        {
                            var RoleID = result.RoleID;
                           remove_Anonymous_Cookies(); //Remove Anonymous_Cookies

                            //HttpContext.Session.SetString("UserID", Convert.ToString(result.ID));
                            //HttpContext.Session.SetString("RoleID", Convert.ToString(result.RoleID));
                            //HttpContext.Session.SetString("Username", Convert.ToString(result.Username));
                            //if (RoleID == 1)
                            //{
                            //    return RedirectToAction("Dashboard", "Admin");
                            //}
                            //else if (RoleID == 2)
                            //{
                            //    return RedirectToAction("Dashboard", "Customer");
                            //}
                            //else if (RoleID == 3)
                            //{
                            //    return RedirectToAction("Dashboard", "SuperAdmin");
                            //}
                            ClaimsIdentity identity = null;
                            if (RoleID == 1)
                            {
                                //Create the identity for the user  
                                identity = new ClaimsIdentity(new[] { new Claim("UserID", Convert.ToString(result.ID)), new Claim("RoleID", Convert.ToString(result.RoleID)), new Claim("Username", Convert.ToString(result.Username)), new Claim(ClaimTypes.Role, "Admin") }, CookieAuthenticationDefaults.AuthenticationScheme);
                                                    
                                var principal = new ClaimsPrincipal(identity);

                                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                                return RedirectToAction("Dashboard", "Admin");
                            }
                            else if (RoleID == 2)
                            {
                                //Create the identity for the user  
                                identity = new ClaimsIdentity(new[] { new Claim("UserID", Convert.ToString(result.ID)), new Claim("RoleID", Convert.ToString(result.RoleID)), new Claim("Username", Convert.ToString(result.Username)), new Claim(ClaimTypes.Role, "Customer") }, CookieAuthenticationDefaults.AuthenticationScheme);

                                var principal = new ClaimsPrincipal(identity);

                                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                                return RedirectToAction("Dashboard", "Customer"); 
                            }
                            else if (RoleID == 3)
                            {
                                //Create the identity for the user  
                                identity = new ClaimsIdentity(new[] { new Claim("UserID", Convert.ToString(result.ID)), new Claim("RoleID", Convert.ToString(result.RoleID)), new Claim("Username", Convert.ToString(result.Username)), new Claim(ClaimTypes.Role, "SuperAdmin") }, CookieAuthenticationDefaults.AuthenticationScheme);

                                var principal = new ClaimsPrincipal(identity);

                                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                                return RedirectToAction("Dashboard", "SuperAdmin");
                            }
                            else
                            {
                                return View();
                            }
                        }
                    }
                    else
                    {
                        ViewBag.errormessage = "Entered Invalid Username and Password";
                        return View();
                    }
                    
                    return View();
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            try
            {
                CookieOptions option = new CookieOptions();

                if (Request.Cookies["EventChannel"] != null)
                {
                    option.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Append("EventChannel", "", option);
                }

                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Login");
            }
            catch (Exception)
            {
                throw;
            }

        }

        [NonAction]
        public void remove_Anonymous_Cookies()
        {
            if (Request.Cookies["EventChannel"] != null)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Append("EventChannel", "", option);
            }
        }

    }
}