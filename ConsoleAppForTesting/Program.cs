using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;
using WcfServiceLibrary;
using System.Threading;

namespace ConsoleAppForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            IUsersRepository userRepo = new UsersRepository(ent);
            //Service sv = new Service();
            Users user = new Users()
            {
                EduId = "555666",
                Password = "666555"
            };
            //sv.AddUser(user);
            Users user2 = userRepo.Find(x => x.EduId == user.EduId).FirstOrDefault();
            //sv.RemoveUser(user2);
            userRepo.Remove(user2);
            //Thread.Sleep(5000);
            //Console.WriteLine(sv.GetAllUsers().Where(x => x.EduId == user.EduId).FirstOrDefault().Password.ToString());

            Console.ReadLine();
        }
    }
}
