using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            set { editedUser = value;OnPropertyChanged(); }
        }

                
        ServiceClient client = new ServiceClient();
        int idToRemove = 0;

        public ICommand SaveCommand { get; private set; }        

        public UserManagerWindowViewModel()
        {
            EditedUser = new Users();
            SaveCommand = new RelayCommand(SaveChanges);
                
        }

        public UserManagerWindowViewModel(Users userToEdit)
        {
            EditedUser = client.GetUserById(userToEdit.Id);
            idToRemove = userToEdit.Id;          
            SaveCommand = new RelayCommand(SaveChanges);
        }

        public Array UserType
        {
            get { return Enum.GetValues(typeof(UserTypes)); }
        }

        public void Add()
        {
            if (idToRemove!=0)
            {
                client.RemoveUserById(idToRemove);
            }
            if (EditedUser.InsertDate==null)
            {
                EditedUser.InsertDate = DateTime.Now;
            }
            EditedUser.ModifyDate = DateTime.Now;
            client.AddUser(EditedUser);
        }

        public void SaveChanges()
        {
            Add();
            EditedUser = new Users();           
            
        }

        
    }
}
