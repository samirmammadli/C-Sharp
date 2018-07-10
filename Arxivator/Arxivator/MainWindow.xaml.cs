using System.Windows;
using Arxivator.Services;

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
    }
}
