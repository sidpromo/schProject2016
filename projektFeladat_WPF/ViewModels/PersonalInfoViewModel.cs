using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class PersonalInfoViewModel
    {
        ServiceClient client = new ServiceClient();

        public string CurrentUserInfo { get; private set; }
        private Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public ICommand EditCommand { get; private set; }

        public PersonalInfoViewModel()
        {
            CurrentUser = client.GetUserById((int)Singleton.Instance.ID);
            EditCommand = new RelayCommand(EditMethod);
        }

        public void EditMethod()
        {
            UserManagerWindow newWindow = new UserManagerWindow(CurrentUser, true);
            newWindow.Show();
        }
    }
}
