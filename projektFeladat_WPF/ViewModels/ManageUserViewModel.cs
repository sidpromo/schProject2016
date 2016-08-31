using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

       static EducationDatabaseEntities ent = new EducationDatabaseEntities();
       static UsersRepository userRepo = new UsersRepository(ent);

        public ICommand DeleteUserCommand { get; private set; }
        public ICommand AddUserCommand { get; private set; }

        public void DeleteMethod()
        {
            userRepo.Remove(SelectedUser);
        }

        public void AddMethod()
        {
            var newWindow = new UserManagerWindow();
            newWindow.Show();
            RefreshMethod();            
            
        }

        public void RefreshMethod()
        {
            UserList = userRepo.GetAll().Where(x => (x.UserType).ToUpper() != "ADMIN");
           
        }
        public ManageUserViewModel()
        {
            //EducationDatabaseEntities ent = new EducationDatabaseEntities();
            //UsersRepository userRepo = new UsersRepository(ent);
            //UserList = userRepo.GetAll().Where(x=>(x.UserType).ToUpper()!="ADMIN");
            RefreshMethod();
            DeleteUserCommand = new RelayCommand(DeleteMethod);
            AddUserCommand = new RelayCommand(AddMethod);
               // FullName = String.Format($"{SelectedUser.FirstName} {SelectedUser.MiddleName} {SelectedUser.LastName}");
               
          
            
        }


    }
}
