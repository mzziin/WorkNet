using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.Areas.JobSeeker.ViewModels;

namespace WorkNet.Areas.JobSeeker.Controllers
{
    public class AccountController : Controller
    {
        // GET: JobSeeker/Account
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
    }
}