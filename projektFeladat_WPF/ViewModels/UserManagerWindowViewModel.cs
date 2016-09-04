using Entities;
using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
using Repository;
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

                
        IService _service = new Service();
        int idToRemove = 0;

        public ICommand SaveCommand { get; private set; }        

        public UserManagerWindowViewModel()
        {
            EditedUser = new Users();
            SaveCommand = new RelayCommand(SaveChanges);
                
        }

        public UserManagerWindowViewModel(Users userToEdit)
        {
            EditedUser = _service.GetUserById(userToEdit.Id);
            idToRemove = userToEdit.Id;          
            SaveCommand = new RelayCommand(SaveChanges);
        }

        public void Add()
        {
            if (idToRemove!=0)
            {
                _service.RemoveUserById(idToRemove);
            }
            if (EditedUser.InsertDate==null)
            {
                EditedUser.InsertDate = DateTime.Now;
            }
            EditedUser.ModifyDate = DateTime.Now;
            _service.AddUser(EditedUser);
        }

        public void SaveChanges()
        {
            Add();
            EditedUser = new Users();           
            
        }

        
    }
}
