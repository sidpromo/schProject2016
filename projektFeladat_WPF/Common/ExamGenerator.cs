using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Linq;
using System.Text;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Common
{
    class ExamGenerator
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random rand = new Random();
        ServiceClient client = new ServiceClient();

        public void GenerateExam()
        {
            Exams newExam = new Exams();
            newExam.InsertDate = DateTime.Now;
            newExam.ModifyDate = DateTime.Now;
            newExam.ModifiedBy = Singleton.Instance.ID;
            
            //vizsga típus beállítása 
            Array values = Enum.GetValues(typeof(ExamTypes));           
            newExam.ExamType=((ExamTypes)values.GetValue(rand.Next(values.Length))).ToString();

            //tárgy hozzáadása
            int subjLength = client.GetAllSubjects().ToList().Count;
            var subject = client.GetAllSubjects().ToList()[rand.Next() % subjLength];
            newExam.SubjectID = subject.Id;

            //vizsgaidőpont generátor
            newExam.ExamDate = ExamDateGenerator();

            //létszám generátor
            int limit = rand.Next(50,500);
            limit = limit - limit % 10;
            newExam.Limit = limit;

            //helyszín generátor
            StringBuilder builder = new StringBuilder();            
            char ch= chars[rand.Next() % chars.Length];
            builder.Append(ch);
            builder.Append(rand.Next(1, 10));
            newExam.Room = builder.ToString();

            //vizsga hozzáadása az adatbázishoz
            int id = client.AddExam(newExam);

            //tanár hozzáadása
            int length = client.GetTeachersFromUsers().ToList().Count();
            var user = client.GetTeachersFromUsers().ToList()[rand.Next() % length];
            client.AddExamsUser(
               new ExamsUsers
               {
                   InsertDate = DateTime.Now,
                   ModifyDate = DateTime.Now,
                   ModifiedBy = Singleton.Instance.ID,
                   ExamId = id,
                   UserId = user.Id
               });
        }

        DateTime ExamDateGenerator()
        {
            DateTime from = DateTime.Now;
            DateTime to = new DateTime(2016, 12, 30);
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rand.NextDouble() * range.Ticks));

            var ret= from + randTimeSpan;
            if (ret.Hour<8 || ret.Hour>18)
            {
                ret = ExamDateGenerator();
            }
            return ret;
        }
    }
}
