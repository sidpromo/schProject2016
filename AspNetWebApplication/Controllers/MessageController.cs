using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetWebApplication.Models;
using WcfServiceLibrary;

namespace AspNetWebApplication.Controllers
{
    public class MessageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        

        // GET: Messages
        public ActionResult Index()
        {
            return View(db.Messages.ToList());
           
        }

        // GET: Messages/Details/5

        //TODO: Ez így biztosan nem jó, ki kell javítani
        /*
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Messages messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }
        */

        // GET: Messages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SentDate,FromUserId,ToUserId,Subject,Message,FromHighlighted,ToHighlighted,FromDeleted,ToDeleted,FromDeletedPerm,ToDeletedPerm,Read")] Messages messages)
        {
            if (ModelState.IsValid)
            {
                //TODO: Ez itt javítandó! Nem használhatod a db objektumot!
                //db.Messages.Add(messages);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(messages);
        }

        // GET: Messages/Edit/5
        //TODO: Ez itt javítandó! Nem használhatod a db objektumot!
        /*
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Messages messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }
        */

        // POST: Messages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SentDate,FromUserId,ToUserId,Subject,Message,FromHighlighted,ToHighlighted,FromDeleted,ToDeleted,FromDeletedPerm,ToDeletedPerm,Read")] Messages messages)
        {
            if (ModelState.IsValid)
            {
                db.Entry(messages).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(messages);
        }

        // GET: Messages/Delete/5
        //TODO: Ez itt javítandó! Nem használhatod a db objektumot!
        /*
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Messages messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }
        */

        // POST: Messages/Delete/5
        //TODO: Ez itt javítandó! Nem használhatod a db objektumot!
        /*
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Messages messages = db.Messages.Find(id);
            db.Messages.Remove(messages);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        */

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
