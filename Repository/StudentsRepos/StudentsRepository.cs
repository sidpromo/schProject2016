using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace Repository.UserRepos
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
