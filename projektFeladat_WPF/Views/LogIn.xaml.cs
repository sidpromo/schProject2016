using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using projektFeladat_WPF.Views;
using System.Windows.Input;
using System.Media;
using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;

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

                ServiceClient client = new ServiceClient();

                //ChannelFactory<IService> channelFactory = new ChannelFactory<IService>("ServiceEndpoint");
                //IService service = channelFactory.CreateChannel();

                string eduId = textBoxEduId.Text, password = passwordBox1.Password;

                if (client.Login(eduId, password))
                {
                    int id = client.GetAllUsers().FirstOrDefault(x => x.EduId == eduId).Id;
                    Singleton.Instance.SetId(id);
                    var windowToOpen = new MainWindow();
                    windowToOpen.Show();
                    this.Close();
                    // camtasia
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
