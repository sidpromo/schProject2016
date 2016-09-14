using projektFeladat_WPF.ViewModels;
using System.Windows;

namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel VM = new MainWindowViewModel(this);
            DataContext = VM;            
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Application app = Application.Current;
            //app.Shutdown();            
        }
    }
}
