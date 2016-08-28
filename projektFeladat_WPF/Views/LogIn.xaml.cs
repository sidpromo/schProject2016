using ConsoleAppDatabaseTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using projektFeladat_WPF.Views;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace projektFeladat_WPF
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            //if (textBoxEduId.Text!="" || passwordBox1.Password!="")
            //{
            //    EducationDatabaseEntities ent = new EducationDatabaseEntities();
            //    foreach (var item in ent.Users)
            //    {
            //        if (textBoxEduId.Text==item.EduId && passwordBox1.Password==item.Password)
            //        {
            //            //MessageBox.Show("LoggedIn as: "+ item.FirstName +" password:"+item.Password +" place of birth: "+ item.BirthPlace); //TODO: kezelni, hogy milyen jogosultsággal lépett be
            //            testWindow testWindow = new testWindow();
            //            testWindow.Show();
            //            return;
            //        }

            //        //else
            //        //{
            //        //    errormessage.Text = " Invalid username or password!";
            //        //}
            //    }
            //    errormessage.Text = " Invalid username or password!";
            //    SystemSounds.Beep.Play();
            //}
            //else
            //{
            //    errormessage.Text = " Username and Password are required!";
            //    SystemSounds.Beep.Play();

            //}

            if (textBoxEduId.Text == String.Empty || passwordBox1.Password == String.Empty)
            {
                errormessage.Text = " Username and Password are required!";
                SystemSounds.Beep.Play();
            }
            else
            {
                using (EducationDatabaseEntities ent = new EducationDatabaseEntities())
                {
                    foreach (var user in ent.Users)
                    {
                        if (textBoxEduId.Text == user.EduId && passwordBox1.Password == user.Password)
                        {
                            //MessageBox.Show("LoggedIn as: "+ item.FirstName +" password:"+item.Password +" place of birth: "+ item.BirthPlace); //TODO: kezelni, hogy milyen jogosultsággal lépett be
                            testWindow testWindow = new testWindow();
                            testWindow.Show();
                            return;
                        }

                        //else
                        //{
                        //    errormessage.Text = " Invalid username or password!";
                        //}
                    }
                }
                errormessage.Text = " Invalid username or password!";
                SystemSounds.Beep.Play();

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
