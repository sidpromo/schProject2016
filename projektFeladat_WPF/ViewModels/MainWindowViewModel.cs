using Entities;
using projektFeladat_WPF.Commands;
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
        IService _service = new Service();

        public string CurrentUserInfo { get; private set; }
        public string WindowTitle { get; private set; }
        private Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public MainWindowViewModel(int id)
        {
            CurrentUser = _service.GetUserById(id);
            CurrentUserInfo = String.Format("{0} {1} {2} ({3})", CurrentUser.FirstName, CurrentUser.MiddleName, CurrentUser.LastName, CurrentUser.EduId);
            WindowTitle= String.Format($"{currentUser.FirstName} {currentUser.MiddleName} {currentUser.LastName} - {_service.GetAppInfo().AppName} v{_service.GetAppInfo().Version}");           
        }

        //service locator statikus osztály
        //Semester info.: Chart - NuGet
    }
}
