using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class UserManagerWindowViewModel : Bindable
    {
        private Users editedUser;

        public Users EditedUser
        {
            get { return editedUser; }
            set { editedUser = value; OnPropertyChanged(); }
        }


        ServiceClient client = new ServiceClient();       

        public ICommand SaveCommand { get; private set; }

        public UserManagerWindowViewModel()
        {
            EditedUser = new Users();
            SaveCommand = new RelayCommand(SaveChanges);

        }

        public UserManagerWindowViewModel(Users userToEdit)
        {
            EditedUser = client.GetUserById(userToEdit.Id);            
            SaveCommand = new RelayCommand(SaveChanges);
        }

        public Array UserType
        {
            get { return Enum.GetValues(typeof(UserTypes)); }
        }

        public void Add()
        {
            EditedUser.InsertDate = DateTime.Now;
            EditedUser.ModifyDate = DateTime.Now;
            EditedUser.ModifiedBy = Singleton.Instance.ID;
            client.AddUser(EditedUser);
        }

        public void SaveChanges()
        {
            
            if (client.GetUserById(EditedUser.Id)==null)
            {
                Add();
            }
            else
            {
                var user = client.GetUserById(EditedUser.Id);
                user = EditedUser;
                user.ModifyDate = DateTime.Now;
                user.ModifiedBy = Singleton.Instance.ID;
                client.UpdateUser(user);
            }
            
            EditedUser = new Users();
        }

        
    }
}
