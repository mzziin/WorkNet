using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkNet.Areas.JobSeeker.Controllers
{
    public class HomeController : Controller
    {
        // GET: JobSeeker/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}