using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
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
   public class MessageWriterWindowViewModel : Bindable
    {
        private IEnumerable<Users> userList;

        public IEnumerable<Users> UserList
        {
            get { return userList; }
            set { userList = value;OnPropertyChanged(); }
        }

        private Messages newMessage;

        public Messages NewMessage
        {
            get { return newMessage; }
            set { newMessage = value;OnPropertyChanged(); }
        }
        private Users selectedUser;

        public Users SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value;OnPropertyChanged(); }
        }

        ServiceClient client = new ServiceClient();
        public ICommand  SendCommand { get; private set; }
        public MessageWriterWindowViewModel()
        {
            UserList = client.GetAllUsers();
            SendCommand = new RelayCommand(SendMethod);
            NewMessage = new Messages();
        }

        void Add()
        {
            NewMessage.SentDate = DateTime.Now;
            NewMessage.FromUserId = Singleton.Instance.ID;
            NewMessage.ToUserId = SelectedUser.Id;
            NewMessage.FromDeleted = false;
            NewMessage.ToDeleted = false;            
            client.AddMessage(NewMessage);
        }
        void SendMethod()
        {
            Add();
            MessageBox.Show($"Message has been sent to:{SelectedUser.FirstName} {SelectedUser.MiddleName} {SelectedUser.LastName}");
            NewMessage = new Messages();
        }

    }
}
