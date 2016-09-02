using Entities;

namespace Repository
{
    public interface ISubjectsRepository : IRepository<Subjects>
    {
        int GetSubjectId(Subjects subject);
    }
}
