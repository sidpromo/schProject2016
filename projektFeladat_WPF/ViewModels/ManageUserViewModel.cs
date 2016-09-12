using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class ManageUserViewModel : Bindable
    {
        private IEnumerable<Users> userList;

        public IEnumerable<Users> UserList
        {
            get { return userList; }
            set { userList = value; OnPropertyChanged(); }
        }

        private Users selectedUser;

        public Users SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged();
            }
        }


        ServiceClient client = new ServiceClient();

        public ICommand DeleteUserCommand { get; private set; }
        public ICommand AddUserCommand { get; private set; }
        public ICommand RefreshComnand { get; private set; }
        public ICommand EditUserCommand { get; private set; }
        public ICommand GenerateCommand { get; private set; }

        public void GenerateUser()
        {
            UserGenerator gen = new UserGenerator();
            client.AddUser(gen.GenerateUser());            
            RefreshMethod();
        }

        public void DeleteMethod()
        {
            if (SelectedUser == null)
            {
                return;
            }
            client.RemoveUserById(SelectedUser.Id);
            RefreshMethod();
        }

        public void AddMethod()
        {
            var newWindow = new UserManagerWindow();
            newWindow.Show();
        }

        public void EditMethod()
        {
            if (SelectedUser == null)
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
            UserList = client.GetAllUsers().Where(x => (x.UserType).ToUpper() != "ADMINISTRATOR");
        }
        public ManageUserViewModel()
        {
            RefreshMethod();
            DeleteUserCommand = new RelayCommand(DeleteMethod);
            AddUserCommand = new RelayCommand(AddMethod);
            RefreshComnand = new RelayCommand(RefreshMethod);
            EditUserCommand = new RelayCommand(EditMethod);
            GenerateCommand = new RelayCommand(GenerateUser);
        }
    }
}
