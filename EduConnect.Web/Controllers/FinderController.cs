using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.EduServiceReference;

namespace EduConnect.Web.Controllers
{
    public class FinderController : Controller
    {
        ServiceClient client = new ServiceClient();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Find(string s) //TODO
        {
            Users u = new Users();
            u=client.GetAllUsers().FirstOrDefault(x => x.FirstName == s);
            return View(u);
        }
    }
}