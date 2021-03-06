﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduConnect.Web.Models;
using EduConnect.Web.ViewModels;
using EduConnect.Web.Security;
using EduConnect.Web.EduServiceReference;

namespace EduConnect.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            AccountModel am = new AccountModel();
            if (string.IsNullOrEmpty(avm.Account.Username) || string.IsNullOrEmpty(avm.Account.Password) ||
                am.login(avm.Account.Username, avm.Account.Password) == null)
            {
                ViewBag.Error = "Account's Invalid";
                return View("Index");
            }
            SessionPersister.Username = avm.Account.Username;
            return RedirectToAction("Index", "Home");
        }




        public ActionResult Logout()
        {
            SessionPersister.Username = string.Empty;
            return RedirectToAction("Index");
        }

    }
}