using Entities;
using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SendCommand = new RelayCommand(SendMethod);
        }

        void SendMethod()
        {
            MessageWriterWindow newWindow = new MessageWriterWindow();
            newWindow.Show();
        }



    }
}
