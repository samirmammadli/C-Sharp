using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
        public Timer ProcessTimer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            var procs = Process.GetProcesses();
            Procs = new List<Process>(procs.OrderBy(x=>x.ProcessName)); 
            ProcGrid.ItemsSource = Procs;
            TimerSet();
        }

        private void TimerSet()
        {
            var callback = new TimerCallback(x => Dispatcher.Invoke(Reload));
            ProcessTimer = new Timer(callback);
            ProcessTimer.Change(1000, 2000);
        }

        private void Reload()
        {
            int id = -15;
            if (Currproc != null)
                id = Currproc.Id;
            Procs = new List<Process>(Process.GetProcesses().OrderBy(x => x.ProcessName));
            Currproc = null;
            ProcGrid.ItemsSource = Procs;
            ProcGrid.Items.Refresh();
            FindSelected(id);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string procName = Currproc.ProcessName;
                Currproc.Kill();
                Reload();
                MessageBox.Show($"{procName} successfully killed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                FindSelected(Currproc.Id);
            }
        }

        private void FindSelected(int id)
        {
            foreach (var item in Procs)
            {
                if (id == item.Id)
                {
                    Currproc = item;
                    ProcGrid.SelectedItem = Currproc;
                    Keyboard.Focus(ProcGrid);
                    break;
                }
            }
        }

        private void BtnRefresh_OnClick(object sender, RoutedEventArgs e)
        {
            int id = -15;
            if (Currproc != null)
                id = Currproc.Id;
            Reload();
            FindSelected(id);
        }

        private void BtnStart_OnClick(object sender, RoutedEventArgs e)
        {
            var wnd = new StartProcess();
            wnd.ShowDialog();
        }
    }
}
