using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
{
    public class ExamsRepository : Repository<Exams>, IExamsRepository
    {
        public ExamsRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott exam id-ját adja vissza.
        /// </summary>
        /// <param name="exam"></param>
        /// <returns></returns>
        public int GetExamId(Exams exam)
        {
            return GetAll().Where(x => x.Id == exam.Id).FirstOrDefault().Id;
        }

    }
}
