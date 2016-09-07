using projektFeladat_WPF.ViewModels;
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
    /// Interaction logic for ExamManagerWindow.xaml
    /// </summary>
    public partial class ExamManagerWindow : Window
    {
        ExamManagerWindowViewModel VM;
        public ExamManagerWindow()
        {
            InitializeComponent();
            VM = new ExamManagerWindowViewModel();
            DataContext = VM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
