using Entities;

namespace Repository
{
    public interface ISubjectsUsersRepository : IRepository<SubjectsUsers>
    {
        int GetSubjectUserId(SubjectsUsers subjectuser);
    }
}
