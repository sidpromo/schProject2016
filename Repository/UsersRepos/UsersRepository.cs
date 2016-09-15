using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Entities;
using System;

namespace Repository
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(DbContext context) : base(context)
        {
        }


        public IEnumerable<Users> GetTeachersFromUsers()
        {
            return GetAll().Where(x => x.UserType.ToUpper() == "TEACHER");
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
            if (Find(x => (x.EduId == eduId) && (x.Password == password)).Count() > 0) return true;
            return false;
        }
    }
}
