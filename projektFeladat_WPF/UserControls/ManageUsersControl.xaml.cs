using projektFeladat_WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace projektFeladat_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for ManageUsersControl.xaml
    /// </summary>
    public partial class ManageUsersControl : UserControl
    {
        ManageUserViewModel VM;
        public ManageUsersControl()
        {
            InitializeComponent();
            VM = new ManageUserViewModel();
            (Content as FrameworkElement).DataContext = VM;
           
        }
    }
}
