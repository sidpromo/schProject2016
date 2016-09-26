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

        public ActionResult Apply(string subjectId) //TODO
        {
            client.AddSubjectsUser(new SubjectsUsers
            {
                EnrollDate = DateTime.Now,
                ModifyDate = DateTime.Now,
                ModifiedBy = SessionPersister.UserID,
                SubjectId = int.Parse(subjectId),
                UserId = SessionPersister.UserID
            });

            return View();
        }
    }
}