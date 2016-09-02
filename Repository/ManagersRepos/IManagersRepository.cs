using Entities;

namespace Repository
{
    public interface IManagersRepository : IRepository<Managers>
    {
        int GetManagerId(Managers manager);
    }
}
