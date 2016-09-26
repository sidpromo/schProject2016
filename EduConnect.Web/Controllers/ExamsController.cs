using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.EduServiceReference;
using EduConnect.Web.Security;

namespace EduConnect.Web.Controllers
{
    public class ExamsController : Controller
    {
        ServiceClient client = new ServiceClient();
        public ActionResult Index()
        {

            IEnumerable<Exams> ExamList=new List<Exams>();
            ExamList = client.GetAllExams().ToList();


            return View(ExamList);
        }
        public ActionResult Apply(string examid) //TODO ?? repo save fail
        {

            client.AddExamsUser(new ExamsUsers
    {
        InsertDate = DateTime.Now,
        ModifyDate = DateTime.Now,
        ModifiedBy = SessionPersister.UserID,
        ExamId = int.Parse(examid),
        UserId = SessionPersister.UserID
    });

            return View();
        }
    }
}