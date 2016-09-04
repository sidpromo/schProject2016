using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using WcfServiceLibrary;

namespace ConsoleAppDatabaseTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Users u = new Users()
            {
                EduId = "555666",
                Password = "555666"
            };
            service.AddUser(u);
        }
    }
}
