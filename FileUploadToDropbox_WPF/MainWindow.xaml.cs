using DropNet;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace FileUploadToDropbox_WPF
{
    /// <summary>
    /// DropNet nevű NuGet-et használ, PDF-eket lehet vele egy kijelölt Dropbox mappába feltölteni
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file PDF extension and default file extension 
            dlg.DefaultExt = ".pdf";
            dlg.Filter = "PDF Files|*.pdf";
           


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                textBox1.Text = filename;
            }
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Missing file!");
                return;
            }
            string filePath = textBox1.Text;
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileName = System.IO.Path.GetFileName(filePath);
            string appKey = "zh6s8ibgjqoqf7u";
            string appSecret = "gpmh7qt9cil81wn";
            string userToken = "7OkXqG_CqOAAAAAAAAAADVONYC5yTQeQk4jblq32FAbTmQ_kG98u2bRgAqVoY3CV";
            var client = new DropNetClient(appKey, appSecret, userToken);

            client.UploadFile("/Public", fileName, fileBytes);


            MessageBox.Show("File uploaded successfully to Dropbox!");
            System.Diagnostics.Process.Start("http://tinyurl.com/z7chn7n");

        }
    }
}
