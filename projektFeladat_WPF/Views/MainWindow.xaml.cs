using projektFeladat_WPF.UserControls;
using projektFeladat_WPF.ViewModels;
using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projektFeladat_WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(int CurrentUserId)
        {
            InitializeComponent(); // random comment
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            UsersRepository userRepo = new UsersRepository(ent);
            Users currentUser = userRepo.GetById(CurrentUserId);

            MainWindowViewModel VM = new MainWindowViewModel(CurrentUserId);
            DataContext = VM;         
        }
    }
}
