using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.EduServiceReference;

namespace EduConnect.Web.Controllers
{
    public class SubjectsController : Controller
    {
        ServiceClient client = new ServiceClient();
        public ActionResult Index()
        {
            Subjects[] s = client.GetAllSubjects();
            return View(s);
        }
    }
}