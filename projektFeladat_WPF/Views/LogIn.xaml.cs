using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using projektFeladat_WPF.Views;
using System.Windows.Input;
using System.Media;
using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System.Threading.Tasks;

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
            Title = "EduConnect Login";
            textBoxEduId.Focus();
        }

        private async void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            await Login();
            //LoginProcedure();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            errormessage.Text = String.Empty;
        }

        private async void KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) await Login();
        }

        /*
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
        */

        private Task Login()
        {
            return Task.Factory.StartNew(() =>
            {
                Dispatcher.Invoke(async() =>
                {
                    button1.IsEnabled = false;
                    if (textBoxEduId.Text.Trim() == String.Empty || passwordBox1.Password.Trim() == String.Empty)
                    {
                        button1.IsEnabled = true;
                        errormessage.Text = " EduId and Password are required!";
                        SystemSounds.Beep.Play();
                        button1.IsEnabled = true;
                    }
                    else
                    {

                        ServiceClient client = new ServiceClient();
                        string eduId = textBoxEduId.Text, password = passwordBox1.Password;

                        if (await client.LoginAsync(eduId, password))
                        {
                            int id = client.GetAllUsers().FirstOrDefault(x => x.EduId == eduId).Id;
                            Singleton.Instance.SetId(id);
                            var windowToOpen = new MainWindow();
                            button1.IsEnabled = true;
                            windowToOpen.Show();
                            this.Close();
                            //camtasia                           
                        }
                        else
                        {
                            button1.IsEnabled = true;
                            errormessage.Text = " Invalid EduId or Password!";
                            SystemSounds.Beep.Play();
                            button1.IsEnabled = true;
                        }
                    }
                });
            });
        }



        private void fieldGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox) (sender as TextBox).SelectAll();
            if (sender is PasswordBox) (sender as PasswordBox).SelectAll();
        }


        //private Task<bool> Login()
        //{
        //    return Task.Factory.StartNew<bool>(() =>
        //    {
        //        bool result=false;
        //        Dispatcher.Invoke(() =>
        //        {
        //            if (textBoxEduId.Text.Trim() == String.Empty || passwordBox1.Password.Trim() == String.Empty)
        //            {
        //                errormessage.Text = " EduId and Password are required!";
        //                SystemSounds.Beep.Play();
        //                result= false;
        //            }
        //            else
        //            {

        //                ServiceClient client = new ServiceClient();
        //                string eduId = textBoxEduId.Text, password = passwordBox1.Password;

        //                if (client.Login(eduId, password))
        //                {
        //                    int id = client.GetAllUsers().FirstOrDefault(x => x.EduId == eduId).Id;
        //                    Singleton.Instance.SetId(id);
        //                    //var windowToOpen = new MainWindow();
        //                    //windowToOpen.Show();
        //                    //this.Close();
        //                    result= true;
        //                    // camtasia
        //                }
        //                else
        //                {
        //                    errormessage.Text = " Invalid EduId or Password!";
        //                    SystemSounds.Beep.Play();
        //                    result= false;
        //                }

        //            }

        //        });
        //        return result;
        //    });            
        //}     


    }
}
