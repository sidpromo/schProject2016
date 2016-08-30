using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.UserRepos
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public bool Login(string eduId, string password)
        {
            IEnumerable<User> Users = GetAll();
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
