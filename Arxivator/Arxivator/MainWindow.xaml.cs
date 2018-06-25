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

            for (int i = 0; i <= 100; i++)
            {
                Dispatcher.CurrentDispatcher.Invoke(() => pbBar.Value = i, DispatcherPriority.Background);
                Thread.Sleep(10);
                
            }

        }
    }
}
