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
            List<Subjects> SubjectList = new List<Subjects>();
            for (int i = 0; i < s.Length; i++)
            {
                SubjectList.Add(s[i]);
            }
            return View(SubjectList);
        }
    }
}