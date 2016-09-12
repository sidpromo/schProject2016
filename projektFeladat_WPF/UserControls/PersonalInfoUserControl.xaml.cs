using System.Windows.Controls;
using projektFeladat_WPF.ViewModels;

namespace projektFeladat_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for PersonalInfoUserControl.xaml
    /// </summary>
    public partial class PersonalInfoUserControl : UserControl
    {
        PersonalInfoViewModel VM;

        public PersonalInfoUserControl()
        {
            InitializeComponent();
            VM = new PersonalInfoViewModel();
            DataContext = VM;
        }
    }
}
