using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
using System;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
   public class MainWindowViewModel :  Bindable
    {
        ServiceClient client = new ServiceClient();

        public string CurrentUserInfo { get; private set; }
        public string WindowTitle { get; private set; }
        public ICommand LogOutCommand { get; private set; }
        private Users currentUser;
        private MainWindow windowToClose;
        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public MainWindowViewModel(MainWindow window)
        {
            CurrentUser = client.GetUserById((int)Singleton.Instance.ID);
            CurrentUserInfo = String.Format("{0} {1} {2} ({3})", CurrentUser.FirstName, CurrentUser.MiddleName, CurrentUser.LastName, CurrentUser.EduId);
            WindowTitle= String.Format($"{currentUser.FirstName} {currentUser.MiddleName} {currentUser.LastName} - {client.GetAppInfo().AppName} v{client.GetAppInfo().Version}");
            LogOutCommand = new RelayCommand(LogOut);
            windowToClose = window;        
        }

        public void LogOut()
        {
            Singleton.Instance.Logout();
            var logInWindow = new LogInWindow();
            windowToClose.Close();           
            logInWindow.Show();

        }
        //service locator statikus osztály
        //Semester info.: Chart - NuGet
    }
}
