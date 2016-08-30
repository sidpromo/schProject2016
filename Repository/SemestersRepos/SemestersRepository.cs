using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class SemestersRepository : Repository<Semesters>, ISemestersRepository
    {
        public SemestersRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott semester id-ját adja vissza.
        /// </summary>
        /// <param name="semester"></param>
        /// <returns></returns>
        public int GetSemesterId(Semesters semester)
        {
            return GetAll().Where(x => x.Id == semester.Id).FirstOrDefault().Id;
        }

    }
}
