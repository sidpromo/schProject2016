using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
   public class MainWindowViewModel :  Bindable
    {
        ServiceClient client = new ServiceClient();

        public string CurrentUserInfo { get; private set; }
        public string WindowTitle { get; private set; }
        private Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public MainWindowViewModel( )
        {
            CurrentUser = client.GetUserById((int)Singleton.Instance.ID);
            CurrentUserInfo = String.Format("{0} {1} {2} ({3})", CurrentUser.FirstName, CurrentUser.MiddleName, CurrentUser.LastName, CurrentUser.EduId);
            //WindowTitle= String.Format($"{currentUser.FirstName} {currentUser.MiddleName} {currentUser.LastName} - {client.GetAppInfo().AppName} v{client.GetAppInfo().Version}");           
        }

        //service locator statikus osztály
        //Semester info.: Chart - NuGet
    }
}
