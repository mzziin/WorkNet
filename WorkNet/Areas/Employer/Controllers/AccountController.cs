using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.Areas.Employer.ViewModels;

namespace WorkNet.Areas.Employer.Controllers
{
    public class AccountController : Controller
    {
        // GET: Employer/Account
        [HttpGet]
        public ActionResult EmployerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployerLogin(EmployerLoginVM employer)
        {
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