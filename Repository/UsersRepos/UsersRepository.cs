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

        /// <summary>
        /// A megadott user id-ját adja vissza.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int GetUserId(Users user)
        {
            return GetAll().Where(x => x.Id == user.Id).FirstOrDefault().Id;
        }

        /// <summary>
        /// Igazat ad vissza, ha egyezést talált a megadott EduId és jelszó párosra.)
        /// </summary>
        /// <param name="eduId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
