using Entities;
using System.Collections.Generic;

namespace Repository
{
    public interface IExamsUsersRepository : IRepository<ExamsUsers>
    {
        int GetExamUserId(ExamsUsers examuser);
        IEnumerable<Users> GetExamStudents(int examId);
    }
}
