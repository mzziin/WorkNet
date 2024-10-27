using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;
using WorkNet.Areas.JobSeeker.ViewModels;

namespace WorkNet.Areas.JobSeeker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly JobService _jobService;
        public DashboardController()
        {
            _jobService = new JobService();
        }
        // GET: JobSeeker/Dashboard
        public ActionResult Home(JobSearchVM jobSearchVM)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchJobs(JobSearchVM jobSearchVM)
        {
            var jobs = _jobService.SearchJobs(jobSearchVM.Title, jobSearchVM.Location);
            return View("SearchResult", jobs);
        }

        [HttpGet]
        public ActionResult SearchResult(IEnumerable<JobDTO> jobs)
        {
            return View(jobs);
        }

        [HttpGet]
        public ActionResult JobDetails(int id)
        {
            var job = _jobService.GetJobById(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        [HttpGet]
        public ActionResult ApplyForJob(int jobId)
        {
            if (Session["JobSeekerUserId"] == null)
                return RedirectToAction("JobSeekerLogin", "Account");

            int jobSeekerUserId = (int)Session["JobSeekerUserId"];
            var result = _jobService.SubmitJobApplication(jobSeekerUserId, jobId);

            TempData["msg"] = result.Message;
            return RedirectToAction("JobDetails", new { id = jobId }); // Redirect to prevent re-apply on refresh
        }
    }
}