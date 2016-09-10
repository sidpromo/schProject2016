using projektFeladat_WPF.ViewModels;
using System.Windows.Controls;

namespace projektFeladat_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for ExamsControl.xaml
    /// </summary>
    public partial class ExamsControl : UserControl
    {
        ExamControlViewModel VM;
        public ExamsControl()
        {
            InitializeComponent();
            VM = new ExamControlViewModel();
            DataContext = VM;
        }
    }
}
