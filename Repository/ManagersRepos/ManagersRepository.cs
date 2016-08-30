using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class ManagersRepository : Repository<Managers>, IManagersRepository
    {
        public ManagersRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott manager id-ját adja vissza.
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public int GetManagerId(Managers manager)
        {
            return GetAll().Where(x => x.Id == manager.Id).FirstOrDefault().Id;
        }

    }
}
