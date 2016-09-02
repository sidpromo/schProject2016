using Entities;

namespace Repository
{
    public interface IAdministratorsRepository : IRepository<Administrators>
    {
        int GetAdminId(Administrators admin);
    }
}
