using projektFeladat_WPF.ViewModels;
using System.Windows.Controls;

namespace projektFeladat_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for MessagesUserControl.xaml
    /// </summary>
    public partial class MessagesUserControl : UserControl
    {
        MessagesControlViewModel VM;
        public MessagesUserControl()
        {
            InitializeComponent();
            VM = new MessagesControlViewModel();
            DataContext = VM;
        }
    }
}
