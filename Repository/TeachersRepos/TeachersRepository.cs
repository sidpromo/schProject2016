using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
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
