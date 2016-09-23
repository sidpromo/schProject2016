using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.EduServiceReference;
using EduConnect.Web.Security;

namespace EduConnect.Web.Controllers
{
    public class SubjectsController : Controller
    {
        ServiceClient client = new ServiceClient();
        public ActionResult Index()
        {
            IEnumerable<Subjects> SubjectList = new List<Subjects>();
            SubjectList = client.GetAllSubjects().ToList();


            return View(SubjectList);
        }

        public ActionResult Apply(Subjects s)
        {
            SubjectsUsers su = new SubjectsUsers();
            su.UserId = SessionPersister.UserID;
            su.SubjectId = s.Id;
            client.AddSubjectsUser(su);
            return View();
        }
    }
}