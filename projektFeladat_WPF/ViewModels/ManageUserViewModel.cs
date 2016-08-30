using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektFeladat_WPF.ViewModels
{
    public class ManageUserViewModel : Bindable
    {
        public IEnumerable<Users> UserList { get; private set; }
        private Users selectedUser;
        //public string FullName { get;  set; }
        public Users SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value;
                OnPropertyChanged();
            }
        }

        public ManageUserViewModel()
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            UsersRepository userRepo = new UsersRepository(ent);
            UserList = userRepo.GetAll();
            
               // FullName = String.Format($"{SelectedUser.FirstName} {SelectedUser.MiddleName} {SelectedUser.LastName}");
          
            
        }


    }
}
