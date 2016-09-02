using Entities;

namespace Repository
{
    public interface IGradesRepository : IRepository<Grades>
    {
        int GetGradeId(Grades grade);
    }
}
