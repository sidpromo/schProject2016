using Entities;

namespace Repository
{
    public interface IStudentsRepository : IRepository<Students>
    {
        int GetStudentId(Students student);
    }
}
