using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduConnect.Web.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }
    }
}