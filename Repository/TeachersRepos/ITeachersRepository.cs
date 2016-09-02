using Entities;

namespace Repository
{
    public interface ITeachersRepository : IRepository<Teachers>
    {
        int GetTeacherId(Teachers teacher);
    }
}
