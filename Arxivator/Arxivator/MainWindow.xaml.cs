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
using System.Windows.Navigation;
using System.Windows.Shapes;
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
            MainVM = new MainViewModel();
            DataContext = MainVM;
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                MainVM.SelectedFile = dialog.FileName;
            }
        }

        private void btnDecompress_Click(object sender, RoutedEventArgs e)
        {
            MainVM.SelectedFile = null;
        }
    }
}
