using Entities;

namespace Repository
{
    public interface ISemestersRepository : IRepository<Semesters>
    {
        int GetSemesterId(Semesters semester);
    }
}
