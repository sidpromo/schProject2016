using Entities;
using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepos
{
    public interface ISubjectsUsersRepository : IRepository<SubjectsUsers>
    {
        int GetSubjectUserId(SubjectsUsers subjectuser);
    }
}
