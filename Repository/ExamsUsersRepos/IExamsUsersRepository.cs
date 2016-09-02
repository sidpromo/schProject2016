using Entities;

namespace Repository
{
    public interface IExamsUsersRepository : IRepository<ExamsUsers>
    {
        int GetExamUserId(ExamsUsers examuser);
    }
}
