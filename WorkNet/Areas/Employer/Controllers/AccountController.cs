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
            var loginDto = new LoginDTO
            {
                Username = employer.Username,
                Password = employer.Password,
                Role = "Employer"
            };
            _accountService.Login(loginDto);
            return RedirectToAction("EmployerLogin");
        }

        [HttpGet]
        public ActionResult EmployerRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployerRegsiter(EmployerRegisterVM employer)
        {
            return RedirectToAction("EmployerLogin");
        }
    }
}