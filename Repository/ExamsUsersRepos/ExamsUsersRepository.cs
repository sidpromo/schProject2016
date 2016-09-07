using System.Linq;
using System.Data.Entity;
using Entities;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ExamsUsersRepository : Repository<ExamsUsers>, IExamsUsersRepository
    {
        public ExamsUsersRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Users> GetExamStudents(int examId)
        {
            IEnumerable<ExamsUsers> value1 = GetAll().Where(x => x.ExamId == examId).Where(y => y.Users.UserType.ToUpper() == "STUDENT");
            List<int?> userIdList = new List<int?>();
            foreach (var v in value1)
            {
                if (!userIdList.Contains(v.UserId)) userIdList.Add(v.UserId);
            }
            IUsersRepository userRepo = new UsersRepository(Context);
            IEnumerable<Users> allUsers = userRepo.GetAll();
            List<Users> userList = new List<Users>();
            foreach (var u in allUsers)
            {
                if (userIdList.Contains(u.Id)) userList.Add(u);
            }
            return userList;
        }

        /// <summary>
        /// A megadott exam-user id-ját adja vissza.
        /// </summary>
        /// <param name="examuser"></param>
        /// <returns></returns>
        public int GetExamUserId(ExamsUsers examuser)
        {
            return GetAll().Where(x => x.Id == examuser.Id).FirstOrDefault().Id;
        }

    }
}
