using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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


        static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        static UsersRepository userRepo = new UsersRepository(ent);

        public ICommand SaveCommand { get; private set; }        

        public UserManagerWindowViewModel()
        {
            EditedUser = new Users { };
            SaveCommand = new RelayCommand(SaveChanges);
                
        }

        public UserManagerWindowViewModel(Users userToEdit)
        {
            EditedUser = userRepo.GetById(userToEdit.Id);
            userRepo.Remove(userRepo.GetById(userToEdit.Id));
            SaveCommand = new RelayCommand(SaveChanges);
        }

        public void Add()
        {
            if (EditedUser.InsertDate==null)
            {
                EditedUser.InsertDate = DateTime.Now;
            }
            EditedUser.ModifyDate = DateTime.Now;
            userRepo.Add(EditedUser);
        }

        public void SaveChanges()
        {
            Add();
            EditedUser = new Users();           
            
        }
    }
}
