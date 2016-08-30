using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class GradesRepository : Repository<Grades>, IGradesRepository
    {
        public GradesRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott grade id-ját adja vissza.
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int GetGradeId(Grades grade)
        {
            return GetAll().Where(x => x.Id == grade.Id).FirstOrDefault().Id;
        }

    }
}
