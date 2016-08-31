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
        public ICommand CloseCommand { get; private set; }

        public UserManagerWindowViewModel()
        {
            EditedUser = new Users { };
            SaveCommand = new RelayCommand(SaveChanges);
                
        }

        public void Add()
        {
            userRepo.Add(EditedUser);
        }

        public void SaveChanges()
        {
            Add();
            EditedUser = new Users();
            //MessageBox.Show("User saved");
        }
    }
}
