using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepos
{
    public interface IUserRepository : IRepository<User>
    {
        bool Login(string eduId, string password);
    }
}
