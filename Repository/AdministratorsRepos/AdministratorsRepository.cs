using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
{
    public class AdministratorsRepository : Repository<Administrators>, IAdministratorsRepository
    {
        public AdministratorsRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott admin id-ját adja vissza.
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int GetAdminId(Administrators admin)
        {
            return GetAll().Where(x => x.Id == admin.Id).FirstOrDefault().Id;
        }

    }
}
