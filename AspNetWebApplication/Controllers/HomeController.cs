using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "EducationDatabase is an extensive system for schools.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }

        public ActionResult Messages()
        {
            ViewBag.Message = "Messages";

            return View();
        }

        public ActionResult Subjects()
        {
            ViewBag.Message = "Subjects";

            return View();
        }
        public ActionResult Exams()
        {
            ViewBag.Message = "Exams";

            return View();
        }
        public ActionResult Finder()
        {
            ViewBag.Message = "Finder";

            return View();
        }
    }
}