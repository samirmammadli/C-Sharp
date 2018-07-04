using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Win32;

namespace Arxivator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public MainViewModel MainVM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MainVM = new MainViewModel(new GzipArchiver());
            DataContext = MainVM;
        }

        private void btnDecompress_Click(object sender, RoutedEventArgs e)
        {
            MainVM.SelectedFile = null;
        }
    }
}
