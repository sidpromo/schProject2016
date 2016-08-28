using ConsoleAppDatabaseTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projektFeladat_WPF
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEduId.Text!="" || passwordBox1.Password!="")
            {
                EducationDatabaseEntities ent = new EducationDatabaseEntities();
                foreach (var item in ent.Users)
                {
                    if (textBoxEduId.Text==item.EduId && passwordBox1.Password==item.Password)
                    {
                        MessageBox.Show("LoggedIn as: "+ item.FirstName +" password:"+item.Password +" place of birth: "+ item.BirthPlace); //TODO: kezelni, hogy milyen jogosultsággal lépett be
                        return;
                    }

                    //else
                    //{
                    //    errormessage.Text = " Invalid username or password!";
                    //}
                }
                errormessage.Text = " Invalid username or password!";
            }
            else
            {
                errormessage.Text = " Username and Password are required!";
                    
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }
    }
}
