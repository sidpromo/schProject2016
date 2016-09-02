using Entities;

namespace Repository
{
    public interface IExamsRepository : IRepository<Exams>
    {
        int GetExamId(Exams exam);
    }
}
