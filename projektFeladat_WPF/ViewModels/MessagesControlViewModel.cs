using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        void foo()
        {
           
        }



    }
}
