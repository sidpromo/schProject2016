using Entities;
using System.Collections.Generic;

namespace Repository
{
    public interface IUsersRepository : IRepository<Users>
    {
        bool Login(string eduId, string password);
        int GetUserId(Users user);
        IEnumerable<Users> GetTeachersFromUsers();
    }
}
