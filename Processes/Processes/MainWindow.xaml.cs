using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Processes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Process> Procs { get; set; }
        public Process Currproc { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            var procs = Process.GetProcesses();
            Procs = new List<Process>(procs);
            //Procs[0].PriorityClass   
            ProcGrid.ItemsSource = Procs;
        }



        private void ProcGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(Currproc.ProcessName);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Currproc?.Kill();
            Procs = new List<Process>(Process.GetProcesses());
        }
    }
}
