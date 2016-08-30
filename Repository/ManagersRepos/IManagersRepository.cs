using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepos
{
    public interface IManagersRepository : IRepository<Managers>
    {
        int GetManagerId(Managers manager);
    }
}
