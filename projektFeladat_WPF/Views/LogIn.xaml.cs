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
using Repository;
using WcfServiceLibrary;
using Entities;

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
            textBoxEduId.Focus();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            LoginProcedure();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }

        private void KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) LoginProcedure();
        }

        private void LoginProcedure()
        {
            if (textBoxEduId.Text.Trim() == String.Empty || passwordBox1.Password.Trim() == String.Empty)
            {
                errormessage.Text = " EduId and Password are required!";
                SystemSounds.Beep.Play();
            }
            else
            {
                EducationDatabaseEntities ent = new EducationDatabaseEntities();
                UsersRepository userRepo = new UsersRepository(ent);
                IService service = new Service();
                
                if (userRepo.Login(textBoxEduId.Text, passwordBox1.Password))
                {
                    int id = userRepo.GetAll().FirstOrDefault(x => x.EduId == textBoxEduId.Text).Id;
                    var windowToOpen = new MainWindow(id);                    
                    windowToOpen.Show();
                    this.Close();




                }
                else
                {
                    errormessage.Text = " Invalid EduId or Password!";
                    SystemSounds.Beep.Play();
                }

            }

        }

        private void fieldGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox) (sender as TextBox).SelectAll();
            if (sender is PasswordBox) (sender as PasswordBox).SelectAll();
        }
    }
}
