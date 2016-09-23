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
        public ActionResult Apply(string examid) //TODO
        {
            ExamsUsers eu = new ExamsUsers(){ UserId = SessionPersister.UserID, ExamId = int.Parse(examid), ModifiedBy=SessionPersister.UserID, InsertDate=DateTime.Now, ModifyDate=DateTime.Now }; //more info needed
            client.AddExamsUser(eu);

 
            return View();
        }
    }
}