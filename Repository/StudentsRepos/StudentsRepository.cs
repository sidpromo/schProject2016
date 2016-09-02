using System.Linq;
using System.Data.Entity;
using Entities;

namespace Repository
{
    public class StudentsRepository : Repository<Students>, IStudentsRepository
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott student id-ját adja vissza.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int GetStudentId(Students student)
        {
            return GetAll().Where(x => x.Id == student.Id).FirstOrDefault().Id;
        }

    }
}
