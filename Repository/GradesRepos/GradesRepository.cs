using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
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
