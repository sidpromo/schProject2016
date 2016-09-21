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
            Exams[] e = client.GetAllExams();
            List<Exams> ExamList=new List<Exams>();
            for (int i = 0; i < e.Length; i++)
            {
                ExamList.Add(e[i]);
            }
            return View(ExamList);
        }
    }
}