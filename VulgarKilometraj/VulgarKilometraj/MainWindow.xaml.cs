using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    [Serializable]
    public class ObservableObject : INotifyPropertyChanged
    {
        [NonSerialized]
        private PropertyChangedEventHandler _PropertyChanged;

        public virtual event PropertyChangedEventHandler PropertyChanged
        {
            add { _PropertyChanged += value; }
            remove { _PropertyChanged -= value; }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            _PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }


    public partial class MainWindow : Window
    {
        public VulgarSheet vg { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            vg = new VulgarSheet();
            this.DataContext = this;
            DataTable.SelectedCellsChanged += CellSelected;
        }

        private void CellSelected(object sender, SelectedCellsChangedEventArgs e)
        {
            if (DataTable.SelectedItem is InfoTable)
            {
                vg.SelectedItem = DataTable.SelectedItem as InfoTable;
                vg.SelectedItem.PropertyChanged += OnKilometerChaged;
            }
        }

        private void OnKilometerChaged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                if (e.PropertyName == "Kilometers")
                {
                    vg.SelectedItem.PropertyChanged -= OnKilometerChaged;
                    InfoTable.totalSum = 200;
                    foreach (var item in vg.Tables)
                    {
                        InfoTable.totalSum -= item.Sum;
                        item.Remains = InfoTable.totalSum;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lbDate.Content = vg.month;
            InfoTable.totalSum = 200;
            var tempList = new List<InfoTable>();
            var tmp = new DateTime(vg.CurDate.Year, vg.CurDate.Month, 1);
            for (int i = vg.CurDate.Month; i == vg.CurDate.Month;)
            {
                tempList.Add(new InfoTable(tmp, 23));
                tmp = tmp.AddDays(1);
                i = tmp.Month;
            }
            vg.Tables = new ObservableCollection<InfoTable>(tempList);
            DataTable.ItemsSource = vg.Tables;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (vg.SelectedItem != null)
            MessageBox.Show(vg.SelectedItem.Kilometers.ToString());
        }
    }

    public class InfoTable : ObservableObject
    {
        public static double totalSum = 200;
        public double TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; OnPropertyChanged(); }
        }

        public static double KmToLitreRate = 0.11;
        private int kilometers;
        public DateTime Date { get; set; }
        private double remain;
        public double Remains
        {
            get { return remain; }
            set { remain = value; OnPropertyChanged("Remains"); }
        }
        private double sum;
        public double Sum
        {
            get { return sum; }
            set
            {
                sum = value;
                OnPropertyChanged();
            }
        }
        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; Sum = kilometers * KmToLitreRate;
                OnPropertyChanged();
            }
        }

        public InfoTable() { }

        public InfoTable(DateTime date, short kilometers)
        {
            this.Date = date;
            this.Kilometers = kilometers;
        }
    }

    static class CheckWeekends
    {
        public static bool IsWeekEnd(this DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }
    }

    public class VulgarSheet : ObservableObject
    {
        private InfoTable selectedItem;
        public InfoTable SelectedItem { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(); } }
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
                OnPropertyChanged();
            }
        }
        private ObservableCollection<InfoTable> tables;
        public ObservableCollection<InfoTable> Tables { get { return tables; } set { tables = value; OnPropertyChanged(); } }
        public VulgarSheet()
        {
            CurDate = DateTime.Now;
        }
    }
}
