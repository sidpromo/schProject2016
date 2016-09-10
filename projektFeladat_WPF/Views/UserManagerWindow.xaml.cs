using projektFeladat_WPF.ViewModels;
using System.Windows;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for UserManagerWindow.xaml
    /// </summary>
    public partial class UserManagerWindow : Window
    {
        public UserManagerWindow()
        {
            InitializeComponent();
            UserManagerWindowViewModel VM = new UserManagerWindowViewModel();
            DataContext = VM;
        }

        public UserManagerWindow(Users user)
        {
            InitializeComponent();
            UserManagerWindowViewModel VM = new UserManagerWindowViewModel(user);
            DataContext = VM;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
