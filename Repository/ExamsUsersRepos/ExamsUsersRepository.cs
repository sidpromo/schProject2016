using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class ExamsUsersRepository : Repository<ExamsUsers>, IExamsUsersRepository
    {
        public ExamsUsersRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott exam-user id-ját adja vissza.
        /// </summary>
        /// <param name="examuser"></param>
        /// <returns></returns>
        public int GetExamUserId(ExamsUsers examuser)
        {
            return GetAll().Where(x => x.Id == examuser.Id).FirstOrDefault().Id;
        }

    }
}
