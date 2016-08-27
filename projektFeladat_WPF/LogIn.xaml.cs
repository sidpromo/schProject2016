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
            if (textBoxUsername.Text!="" && passwordBox1.Password!="")
            {
                DBConnection connObject = new DBConnection();
                connObject.Connection();

                //tábla neve nincs kitöltve!!
                string sql = "SELECT COUNT(*) FROM táblaneve WHERE [USERNAME]=@Username AND [PASSWORD]=@Password ";

                SqlCommand com = new SqlCommand(sql, connObject.con);
                com.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                com.Parameters.AddWithValue("@Password", passwordBox1.Password);
                int isValidUser = Convert.ToInt32(com.ExecuteScalar());

                if (isValidUser==1)
                {
                    MessageBox.Show("LoggedIn"); //TODO: kezelni, hogy milyen jogosultsággal lépett be
                }
                else
                {
                    errormessage.Text = " Invalid username or password!";
                }
                connObject.con.Close();
            }
            else
            {
                errormessage.Text = " Username and Password are required!";
                
            }


        }
    }
}
