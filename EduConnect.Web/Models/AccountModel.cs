using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduConnect.Web.Models
{
    public class AccountModel
    {
        private List<Account> listAccounts = new List<Account>();

        public AccountModel()
        {
            listAccounts.Add(new Account { Username = "acc1", Password = "123", Roles = new string[] { "superadmin", "admin", "employee" } });
            listAccounts.Add(new Account { Username = "acc2", Password = "123", Roles = new string[] { "admin", "employee" } });
            listAccounts.Add(new Account { Username = "acc3", Password = "123", Roles = new string[] { "employee" } });
        }

        public Account find(string username)
        {
            return listAccounts.Where(acc => acc.Username.Equals(username)).FirstOrDefault();
        }

        public Account login(string username, string password)
        {
            return listAccounts.Where(acc => acc.Username.Equals(username) && acc.Password.Equals(password)).FirstOrDefault();
        }
    }
}