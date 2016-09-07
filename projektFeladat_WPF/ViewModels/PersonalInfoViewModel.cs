using projektFeladat_WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class PersonalInfoViewModel
    {
        IService _service = new Service();

        public string CurrentUserInfo { get; private set; }
        private Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public PersonalInfoViewModel()
        {
            CurrentUser = _service.GetUserById((int)Singleton.Instance.ID);
        }
    }
}
