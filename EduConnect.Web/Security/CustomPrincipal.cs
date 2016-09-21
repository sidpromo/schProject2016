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
        //private Account Account;
        private Users User;

        public CustomPrincipal(Users user)
        {
            this.User = user;
            this.Identity = new GenericIdentity(user.EduId);
        }

        public IIdentity Identity
        {
            get;
            set;
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.User.UserType.Contains(r));
        }
    }
}