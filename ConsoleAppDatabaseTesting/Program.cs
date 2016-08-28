using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDatabaseTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();

            User u = new User()
            {
                EduId = "52AF28",
                Password = "testPassword",
                Active = true,
                UserType = "Student",
                FirstName = "Peter",
                MiddleName = null,
                LastName = "Smith",
                MothersName = "Julie Croeger",
                BirthDate = new DateTime(1987, 4, 12),
                BirthPlace = "Paris",
                Nationality = "hungarian",
                PersonalId = "82234234CA",
                MedicalCardId = "223181053",
                SemesterId = null,
                SemesterState = "active",
                EduCardId = "2344234BB"
            };

            User u2 = new User()
            {
                InsertDate = DateTime.Now,
                EduId = "72BA11",
                Password = "testPassword",
                Active = true,
                UserType = "Teacher",
                FirstName = "Robert",
                MiddleName = null,
                LastName = "Bay",
                MothersName = "Kate Popps",
                BirthDate = new DateTime(1958, 7, 9),
                BirthPlace = "Budapest",
                Nationality = "hungarian",
                PersonalId = "62234234CA",
                MedicalCardId = "224185053",
                SemesterId = null,
                SemesterState = "active",
                EduCardId = "3844234DC"
            };

            //ent.Users.Add(u2);

            ent.Users.Remove(ent.Users.First(x => x.Id == 2));
            ent.Users.Remove(ent.Users.First(x => x.Id == 3));

            ent.SaveChanges();
        }
    }
}
