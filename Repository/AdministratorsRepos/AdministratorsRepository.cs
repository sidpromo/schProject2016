using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
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
