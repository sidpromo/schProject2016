using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(DbContext context) : base(context)
        {
        }

        public bool Login(string eduId, string password)
        {
            IEnumerable<Users> Users = GetAll();
            foreach (var user in Users)
            {
                if(eduId == user.EduId && password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
