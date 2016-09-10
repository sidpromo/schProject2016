using projektFeladat_WPF.ViewModels;
using System.Windows;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for ExamManagerWindow.xaml
    /// </summary>
    public partial class ExamManagerWindow : Window
    {
        ExamManagerWindowViewModel VM;
        public ExamManagerWindow()
        {
            InitializeComponent();
            VM = new ExamManagerWindowViewModel();
            DataContext = VM;
        }

        public ExamManagerWindow(Exams examToEdit)
        {
            InitializeComponent();
            VM = new ExamManagerWindowViewModel(examToEdit);
            DataContext = VM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
