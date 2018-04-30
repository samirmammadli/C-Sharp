using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace VulgarKilometraj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class ColumnState
    {

    }


    public partial class MainWindow : Window
    {
        public VulgarSheet vg { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            vg = new VulgarSheet();
            this.DataContext = this;
            DataTable.ItemsSource = vg.Tables;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lbDate.Content = vg.month;
            var tempList = new List<InfoTable>();
            var tmp = new DateTime(vg.CurDate.Year, vg.CurDate.Month, 1);
            for (int i = vg.CurDate.Month; i == vg.CurDate.Month;)
            {
                tempList.Add(new InfoTable(tmp, 23.5 , 24.7, 15));
                tmp = tmp.AddDays(1);
                i = tmp.Month;
            }
            vg.Tables = new ObservableCollection<InfoTable>(tempList);
            DataTable.ItemsSource = vg.Tables;
        }
    }

    public class InfoTable
    {
        public static double KmToLitreRate = 0.11;
        public DateTime date { get; set; }
        public double kilometers { get; set; }
        public double sum { get; set; }
        public double remain { get; set; }

        public InfoTable() { }

        public InfoTable(DateTime date, double kilometers, double sum, double remain)
        {
            this.date = date;
            this.kilometers = kilometers;
            this.sum = sum;
            this.remain = remain;
        }
    }

    static class CheckWeekends
    {
        public static bool IsWeekEnd(this DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }
    }

    public class VulgarSheet
    {
        public string month { get; set; }
        private DateTime curDate;
        public DateTime CurDate
        {
            get { return curDate; }
            set
            {
                curDate = value;
                curDate = new DateTime(curDate.Year, CurDate.Month, 1);
                month = CurDate.ToString("yyyy il MMMM ", new System.Globalization.CultureInfo("az-AZ")) + "ayi ucun";
            }
        }
        public ObservableCollection<InfoTable> Tables { get; set; }
        public VulgarSheet()
        {
            CurDate = DateTime.Now;
            Tables = new ObservableCollection<InfoTable>();
        }
    }
}
