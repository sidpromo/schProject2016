using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
{
    public class SubjectsRepository : Repository<Subjects>, ISubjectsRepository
    {
        public SubjectsRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott subject id-ját adja vissza.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public int GetSubjectId(Subjects subject)
        {
            return GetAll().Where(x => x.Id == subject.Id).FirstOrDefault().Id;
        }

    }
}
