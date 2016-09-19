using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Linq;
using System.Web;
using EduConnect.Web.Models;

namespace EduConnect.Web.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private Account Account;
        private AccountModel am = new AccountModel();

        public CustomPrincipal(string username)
        {
            this.Account = am.find(username);
            this.Identity = new GenericIdentity(username);

        }
        public IIdentity Identity
        {
            get;
            set;
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.Account.Roles.Contains(r));
        }
    }
}