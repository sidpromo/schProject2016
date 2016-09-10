using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
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
        public PersonalInfoViewModel()
        {
            CurrentUser = client.GetUserById((int)Singleton.Instance.ID);
        }
    }
}
