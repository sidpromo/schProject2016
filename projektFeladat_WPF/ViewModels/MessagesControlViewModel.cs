using Entities;
using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
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
   public class MessagesControlViewModel : Bindable
    {

        private IEnumerable<Messages> receivedMsgList;

        public IEnumerable<Messages> ReceivedMsgList
        {
            get { return receivedMsgList; }
            set { receivedMsgList = value;OnPropertyChanged(); }
        }

        private IEnumerable<Messages> sentMsgList;

        public IEnumerable<Messages> SentMsgList
        {
            get { return sentMsgList; }
            set { sentMsgList = value;OnPropertyChanged(); }
        }

        private Messages selectedMessage;

        public Messages SelectedMessage
        {
            get { return selectedMessage; }
            set { selectedMessage = value;OnPropertyChanged(); }
        }

        IService _service = new Service();
        public ICommand DeleteCommand { get; private set; }
        public ICommand SendCommand { get; private set; }
        public MessagesControlViewModel()
        {
            RefreshMethod();
            SendCommand = new RelayCommand(SendMethod);
            DeleteCommand = new RelayCommand(DeleteMethod);
        }

        void SendMethod()
        {
            MessageWriterWindow newWindow = new MessageWriterWindow();
            newWindow.Show();
        }

        void DeleteMethod()
        {
            
            if (SelectedMessage.FromUserId==Singleton.Instance.ID)
            {
                //SelectedMessage.FromDeleted = true;
                _service.GetMessageById(SelectedMessage.Id).FromDeleted = true;                
                MessageBox.Show("Message has been deleted from Sent messages");
            }
            else if (SelectedMessage.ToUserId == Singleton.Instance.ID)
            {
                //SelectedMessage.ToDeleted = true;
                _service.GetMessageById(SelectedMessage.Id).ToDeleted = true;
                MessageBox.Show("Message has been deleted from Inbox");
            }
            if (SelectedMessage.ToDeleted==true && SelectedMessage.FromDeleted==true)
            {
                _service.RemoveMessageById(SelectedMessage.Id);
            }
            RefreshMethod();
        }
        void RefreshMethod()
        {
            SentMsgList = new List<Messages>();
            ReceivedMsgList= new List<Messages>();
            SentMsgList = _service.GetSentMessages((int)Singleton.Instance.ID).Where(m=>m.FromDeleted==false);
            ReceivedMsgList = _service.GetReceivedMessages((int)Singleton.Instance.ID).Where(m => m.ToDeleted == false);
        }


    }
}
