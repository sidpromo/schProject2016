using projektFeladat_WPF.Common;
using projektFeladat_WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class ManageUserViewModel : Bindable
    {
       // public IEnumerable<Users> UserList { get; private set; }
        private IEnumerable<Users> userList;

        public IEnumerable<Users> UserList
        {
            get { return userList; }
            set { userList = value;OnPropertyChanged(); }
        }

        private Users selectedUser;
        //public string FullName { get;  set; }
        public Users SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged();
            }
        }

        //static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        //static IUsersRepository userRepo = new UsersRepository(ent);
        IService _service = new Service();

        public ICommand DeleteUserCommand { get; private set; }
        public ICommand AddUserCommand { get; private set; }
        public ICommand RefreshComnand { get; private set; }
        public ICommand EditUserCommand { get; private set; }

        public void DeleteMethod()
        {
            if (SelectedUser == null)
            {
                return;
            }
            _service.RemoveUserById(SelectedUser.Id);            
            RefreshMethod();
        }

        public void AddMethod()
        {
            var newWindow = new UserManagerWindow();
            newWindow.Show();
        }

        public void EditMethod()
        {
            if (SelectedUser==null)
            {
                return;
            }
            var newWindow = new UserManagerWindow(SelectedUser);
            newWindow.Show();
        }

        public void RefreshMethod()
        {
            List<Users> newList = new List<Users>();
            UserList = newList;
           UserList =_service.GetAllUsers().Where(x => (x.UserType).ToUpper() != "ADMIN");
        }
        public ManageUserViewModel()
        {
            RefreshMethod();
            DeleteUserCommand = new RelayCommand(DeleteMethod);
            AddUserCommand = new RelayCommand(AddMethod);
            RefreshComnand = new RelayCommand(RefreshMethod);
            EditUserCommand = new RelayCommand(EditMethod);
        }
    }
}
