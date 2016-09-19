using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Linq;
using System.Web;
using EduConnect.Web.Models;
using EduConnect.Web.EduServiceReference;

namespace EduConnect.Web.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private Account Account;
        private Users users;

        public CustomPrincipal(Users users)
        {
            this.users = users;
            this.Identity = new GenericIdentity(users.EduId);
        }

        public CustomPrincipal(Account account)
        {
            this.Account = account;
            this.Identity = new GenericIdentity(account.Username);

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