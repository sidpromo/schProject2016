using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.ViewModels;
using System.Windows;
using WcfServiceLibrary;
namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for SubjectManagerWindow.xaml
    /// </summary>
    public partial class SubjectManagerWindow : Window
    {
        ServiceClient client = new ServiceClient();
        SubjectManagerWindowViewModel VM;
        public SubjectManagerWindow()
        {
            InitializeComponent();
            VM = new SubjectManagerWindowViewModel();
            DataContext = VM;

        }

        public SubjectManagerWindow(Subjects subjectToEdit)
        {
            InitializeComponent();
            if (client.GetSubjectTeacher(subjectToEdit) != null)
            {
                teacherTextBox.Text = client.GetSubjectTeacher(subjectToEdit).EduId;
            }
            VM = new SubjectManagerWindowViewModel(subjectToEdit);            
            DataContext = VM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
