using projektFeladat_WPF.ViewModels;
using System.Windows;

namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for MessageWriterWindow.xaml
    /// </summary>
    public partial class MessageWriterWindow : Window
    {
        MessageWriterWindowViewModel VM;
        public MessageWriterWindow()
        {
            InitializeComponent();
            VM = new MessageWriterWindowViewModel();
            DataContext = VM;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
