using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
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
