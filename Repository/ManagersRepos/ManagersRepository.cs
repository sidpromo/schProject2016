using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
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
