using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.EduServiceReference;
using EduConnect.Web.Security;

namespace EduConnect.Web.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            ServiceClient client = new ServiceClient();
            int userId = client.GetAllUsers().FirstOrDefault(x => x.EduId == SessionPersister.Username).Id;

            IEnumerable<Messages> messagesListByIdWhere = client.GetAllMessages().Where(x => x.ToUserId == userId);
            List<Messages> messagesList = messagesListByIdWhere.ToList();

            return View(messagesList);
        }
    }
}