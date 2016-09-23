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
        ServiceClient client = new ServiceClient();
        // GET: Message
        public ActionResult Index()
        {
            
            int userId = client.GetAllUsers().FirstOrDefault(x => x.EduId == SessionPersister.Username).Id;

            IEnumerable<Messages> messagesListByIdWhere = client.GetAllMessages().Where(x => x.ToUserId == userId);
            List<Messages> messagesList = messagesListByIdWhere.ToList();
            IEnumerable<Messages> sent = client.GetAllMessages().Where(x => x.FromUserId == userId);
            List<Messages> Sent = sent.ToList();
            messagesList.AddRange(Sent);

            return View(messagesList);
        }

        [HttpPost]
        public ActionResult NewMessage(Messages m) //TODO
        {
            client.AddMessage(m);
            ViewBag.Message("Message sent!");
            return View("Index");
        }

        public ActionResult New()
        {
            return View("View");
        }

        public ActionResult Read()
        {
            return View("Read");
        }

    }

    public class Converter
    {
        ServiceClient client = new ServiceClient();
        public string idToName(int? userId)
        {
            string userName = string.Empty;
            userName = client.GetAllUsers().FirstOrDefault(x => x.Id == userId).FirstName +" "+ client.GetAllUsers().FirstOrDefault(x => x.Id == userId).LastName;
            return userName;
        }
    }

}