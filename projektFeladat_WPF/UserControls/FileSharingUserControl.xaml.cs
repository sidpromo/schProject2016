﻿using projektFeladat_WPF.ViewModels;
using System.Windows.Controls;

namespace projektFeladat_WPF.UserControls
{

    /// <summary>
    /// Interaction logic for FileSharingUserControl.xaml
    /// </summary>
    public partial class FileSharingUserControl : UserControl
    {
        FileSharingViewModel VM;
        public FileSharingUserControl()
        {
            InitializeComponent();
            VM = new FileSharingViewModel();
            DataContext = VM;
        }
    }
}
