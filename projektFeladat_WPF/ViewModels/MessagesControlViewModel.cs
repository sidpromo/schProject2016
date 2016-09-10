using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
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

        ServiceClient client = new ServiceClient();
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

                //client.GetMessageById(SelectedMessage.Id).FromDeleted = true;                
                //client.UpdateMessage(client.GetMessageById(SelectedMessage.Id));

                Messages msg = client.GetMessageById(SelectedMessage.Id);
                msg.FromDeleted = true;
                client.UpdateMessage(msg);
                             
                MessageBox.Show("Message has been deleted from Sent messages");
            }
            else if (SelectedMessage.ToUserId == Singleton.Instance.ID)
            {
                //SelectedMessage.ToDeleted = true;
                //client.GetMessageById(SelectedMessage.Id).ToDeleted = true;

                Messages msg = client.GetMessageById(SelectedMessage.Id);
                msg.ToDeleted = true;
                client.UpdateMessage(msg);

                MessageBox.Show("Message has been deleted from Inbox");
            }
            if (SelectedMessage.ToDeleted==true && SelectedMessage.FromDeleted==true)
            {
                client.RemoveMessageById(SelectedMessage.Id);
            }
            RefreshMethod();
        }
        void RefreshMethod()
        {
            SentMsgList = new List<Messages>();
            ReceivedMsgList= new List<Messages>();
            SentMsgList = client.GetSentMessages((int)Singleton.Instance.ID).Where(m=>m.FromDeleted==false);
            ReceivedMsgList = client.GetReceivedMessages((int)Singleton.Instance.ID).Where(m => m.ToDeleted == false);
        }


    }
}
