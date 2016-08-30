using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class TeachersRepository : Repository<Teachers>, ITeachersRepository
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott teacher id-ját adja vissza.
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int GetTeacherId(Teachers teacher)
        {
            return GetAll().Where(x => x.Id == teacher.Id).FirstOrDefault().Id;
        }

    }
}
