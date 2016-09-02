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
    public class SubjectsUsersRepository : Repository<SubjectsUsers>, ISubjectsUsersRepository
    {
        public SubjectsUsersRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott subjectuser id-ját adja vissza.
        /// </summary>
        /// <param name="subjectuser"></param>
        /// <returns></returns>
        public int GetSubjectUserId(SubjectsUsers subjectuser)
        {
            return GetAll().Where(x => x.Id == subjectuser.Id).FirstOrDefault().Id;
        }

    }
}
