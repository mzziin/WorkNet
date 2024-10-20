using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNet.Areas.JobSeeker.ViewModels;
using BLL.Services;
using BLL.DTOs;

namespace WorkNet.Areas.JobSeeker.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        // login
        [HttpGet]
        public ActionResult JobSeekerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobSeekerLogin(JobSeekerLoginVM jobSeeker)
        {
            if (ModelState.IsValid)
            {
                var loginDTO = new LoginDTO
                {
                    Username = jobSeeker.Username,
                    Password = jobSeeker.Password,
                    Role = "JobSeeker"
                };
                var result = _accountService.Login(loginDTO);
                TempData["JobSeekerLoginMsg"] = result.Message;

                if (result.IsSuccess)
                    return RedirectToAction("Index", "Home");
                else
                    return View(jobSeeker);
            }
            return View(jobSeeker);
        }

        // register
        [HttpGet]
        public ActionResult JobSeekerRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobSeekerRegister(JobSeekerRegisterVM jobSeeker)
        {
            if (ModelState.IsValid)
            {
                var registerDTO = new JobSeekerRegisterDTO
                {
                    FullName = jobSeeker.FullName,
                    Address = jobSeeker.Address,
                    ContactNumber = jobSeeker.ContactNumber,
                    Skills = jobSeeker.Skills,
                    Experience = jobSeeker.Experience,
                    ResumePath = jobSeeker.ResumePath,
                    Username = jobSeeker.Username,
                    Password = jobSeeker.Password
                };
                var result = _accountService.RegisterJobSeeker(registerDTO);
                TempData["JobSeekerRegisterMsg"] = result.Message;

                if (result.IsSuccess)
                    return RedirectToAction("JobSeekerLogin");
                else
                    return View(jobSeeker);
            }
            return View(jobSeeker);
        }
    }
}