using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepos
{
    public interface IUsersRepository : IRepository<Users>
    {
        bool Login(string eduId, string password);
    }
}
