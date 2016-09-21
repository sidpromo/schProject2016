using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduConnect.Web.EduServiceReference;

namespace EduConnect.Web.Security
{
    public class SessionPersister
    {
        static string usernameSessionvar = "username";
        
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null) return string.Empty;
                var sessionVar = HttpContext.Current.Session[usernameSessionvar];
                if (sessionVar != null) return sessionVar as string;
                return null;
            }
            set
            {
                HttpContext.Current.Session[usernameSessionvar] = value;
            }
        }
        public static int UserID
        {
            get
            {
                ServiceClient client = new ServiceClient();
                if (HttpContext.Current == null) return 0;
                var sessionVar = client.GetAllUsers().FirstOrDefault(x => x.EduId == Username).Id;
                return sessionVar;
            }
            set
            {
                UserID = value;                
            }
        }
    }
}