using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.Areas.Employer.ViewModels;
using BLL.Services;
using BLL.DTOs;

namespace WorkNet.Areas.Employer.Controllers
{
    public class AccountController : Controller
    {
        AccountService _accountService = new AccountService();
        // GET: Employer/Account
        [HttpGet]
        public ActionResult EmployerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployerLogin(EmployerLoginVM employer)
        {
            if (ModelState.IsValid)
            {
                var loginDto = new LoginDTO
                {
                    Username = employer.Username,
                    Password = employer.Password,
                    Role = "Employer"
                };
                if (_accountService.Login(loginDto))
                {
                    TempData["LoginMsg"] = "Successfully logged in";
                    return RedirectToAction("EmployerLogin");
                }
                else
                {
                    TempData["LoginMsg"] = "Invalid username or password";
                    return RedirectToAction("index", "Home");
                }
                
            }
            return View(employer);
        }

        [HttpGet]
        public ActionResult EmployerRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployerRegsiter(EmployerRegisterVM employer)
        {
            if (ModelState.IsValid)
            {
                var registerDTO = new EmployerRegisterDTO
                {
                    CompanyName = employer.CompanyName,
                    Address = employer.Address,
                    ContactPerson = employer.ContactPerson,
                    ContactEmail = employer.ContactEmail,
                    Industry = employer.Industry,
                    Username = employer.Username,
                    Password = employer.Password
                };
                if (_accountService.RegisterEmployer(registerDTO))
                {
                    TempData["RegisterMsg"] = "Employer Registered Successfully";
                    RedirectToAction("EmployerLogin");
                }
                else
                {
                    TempData["RegisterMsg"] = "Someting went wrong";
                    return View(employer);
                }
            }
            return View(employer);
        }
    }
}