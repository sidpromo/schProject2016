using Entities;

namespace Repository
{
    public interface ISubjectsUsersRepository : IRepository<SubjectsUsers>
    {
        int GetSubjectUserId(SubjectsUsers subjectuser);
        Users GetSubjectTeacher(Subjects subject);
        int GetRegisteredStudentsCount(Subjects subject);
        int GetRegisteredTeachersCount(Subjects subject);
        void RegisterUserToSubject(Users user, Subjects subject);
    }
}
