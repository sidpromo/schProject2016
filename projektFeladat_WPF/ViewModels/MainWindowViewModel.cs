using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektFeladat_WPF.ViewModels
{
   public class MainWindowViewModel :  Bindable
    {
        static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        static UsersRepository userRepo = new UsersRepository(ent);

        public string CurrentUserInfo { get; private set; }
        private Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public MainWindowViewModel(int id)
        {
            CurrentUser = userRepo.GetById(id);
            CurrentUserInfo = String.Format("{0} {1} {2} ({3})", CurrentUser.FirstName, CurrentUser.MiddleName, CurrentUser.LastName, CurrentUser.EduId);
           

        }
    }
}
