using Entities;
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
    /// Interaction logic for SubjectManagerWindow.xaml
    /// </summary>
    public partial class SubjectManagerWindow : Window
    {
        SubjectManagerWindowViewModel VM;
        public SubjectManagerWindow()
        {
            InitializeComponent();
            VM = new SubjectManagerWindowViewModel();
            DataContext = VM;

        }

        public SubjectManagerWindow(Subjects subjectToEdit)
        {
            InitializeComponent();
            VM = new SubjectManagerWindowViewModel(subjectToEdit);
            DataContext = VM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
