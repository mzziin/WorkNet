using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.Areas.Employer.ViewModels;
using BLL.Services;
using BLL.DTOs;
using Utility;

namespace WorkNet.Areas.Employer.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
 
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

                var result = _accountService.Login(loginDto);
                TempData["LoginMsg"] = result.Message;

                if (result.IsSuccess)
                {
                    Session["EmployerUserId"] = result.UserId;
                    return RedirectToAction("JobSeekerLogin", "Account", new { area="JobSeeker" });
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
        public ActionResult EmployerRegister(EmployerRegisterVM employer)
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

                var result = _accountService.RegisterEmployer(registerDTO);
                TempData["RegisterMsg"] = result.Message;

                if (result.IsSuccess)
                    return RedirectToAction("EmployerLogin");
            }
            return View(employer);
        }

        [HttpGet]
        public void Logout()
        {
            Session["EmployerUserId"] = null;
        }
    }
}