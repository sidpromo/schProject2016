using ConsoleAppDatabaseTesting;
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
        public MainWindow(string CurrentUserEduId)
        {
            InitializeComponent(); // random comment
            using (EducationDatabaseEntities ent = new EducationDatabaseEntities())
            {
                User currentUser = ent.Users.FirstOrDefault(u => u.EduId == CurrentUserEduId);
                string currentUserInfo = String.Format("{0} {1} {2} ({3})", currentUser.FirstName, currentUser.MiddleName, currentUser.LastName, currentUser.EduId);
                this.Title = currentUserInfo + "- EducationDatabase v0.2";
                currentUserLabel.Content = currentUserInfo;
            }
        }
    }
}
