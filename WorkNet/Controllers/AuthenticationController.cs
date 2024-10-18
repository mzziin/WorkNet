using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.ViewModels;

namespace WorkNet.Controllers
{
    public class AuthenticationController : Controller
    {
        // Jobseeker
        [HttpGet]
        public ActionResult JobSeekerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobSeekerLogin(JobSeekerLoginVM jobSeeker)
        {
            return RedirectToAction("JobSeekerLogin");
        }

        [HttpGet]
        public ActionResult JobSeekerRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobSeekerRegsiter(JobSeekerRegisterVM jobSeeker)
        {
            return RedirectToAction("JobSeekerLogin");
        }

        // Employer

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