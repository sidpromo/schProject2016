using projektFeladat_WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace projektFeladat_WPF
{
    /// <summary>
    /// Interaction logic for SubjectsControl.xaml
    /// </summary>
    public partial class SubjectsControl : UserControl
    {
        SubjectControlViewModel VM;
        public SubjectsControl()
        {
            InitializeComponent();
            VM = new SubjectControlViewModel();
            (Content as FrameworkElement).DataContext = VM;
        }
    }
}
