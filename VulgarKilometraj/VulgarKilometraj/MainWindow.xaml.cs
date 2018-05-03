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
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            vg = new VulgarSheet();
            this.DataContext = this;
            DataTable.SelectedCellsChanged += CellSelected;

            //this.Height = 1100;
            //grdColumn1.Width = new GridLength(750);
            //testim.Margin = new Thickness(160, 160, 160, 160);
        }

        private void CellSelected(object sender, SelectedCellsChangedEventArgs e)
        {
            if (DataTable.SelectedItem is InfoTable)
            {
                vg.SelectedItem = DataTable.SelectedItem as InfoTable;
                vg.SelectedItem.PropertyChanged += OnKilometerChaged;
            }
        }

        private void SetValuesByDiapazon(short from, short to)
        {
            int i = 0;
            double.TryParse(tbTotalSum.Text, out InfoTable.totalSum);
            while ((InfoTable.totalSum < -20 || InfoTable.totalSum > 20) && i < 1)
            {
                double.TryParse(tbTotalSum.Text, out InfoTable.totalSum);
                foreach (var item in vg.Tables)
                {
                    if (item.Date.CheckSaturday() && cbSaturday.IsChecked == false)
                    {
                        item.Kilometers = 0;
                        item.Remains = InfoTable.totalSum;
                    }
                    else if (item.Date.CheckSunday() && cbSunday.IsChecked == false)
                    {
                        item.Kilometers = 0;
                        item.Remains = InfoTable.totalSum;
                    }
                    else
                    {
                        item.Kilometers = (short)rnd.Next(from, to);
                        InfoTable.totalSum -= item.Sum;
                        item.Remains = InfoTable.totalSum;
                    }
                }
                i++;
            }
            
        }

        private void OnKilometerChaged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                if (e.PropertyName == "Kilometers")
                {
                    vg.SelectedItem.PropertyChanged -= OnKilometerChaged;
                    double.TryParse(tbTotalSum.Text, out InfoTable.totalSum);
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
            double.TryParse(tbTotalSum.Text, out InfoTable.totalSum);
            var tempList = new List<InfoTable>();
            var tmp = new DateTime(vg.CurDate.Year, vg.CurDate.Month, 1);
            for (int i = vg.CurDate.Month; i == vg.CurDate.Month;)
            {
                tempList.Add(new InfoTable(tmp, 0));
                tmp = tmp.AddDays(1);
                i = tmp.Month;
            }
            vg.Tables = new ObservableCollection<InfoTable>(tempList);
            DataTable.ItemsSource = vg.Tables;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                short.TryParse(tbFrom.Text, out short from);
                short.TryParse(tbTo.Text, out short to);
                SetValuesByDiapazon(from, to);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                this.Height = 1100;
                grdColumn1.Width = new GridLength(750);
                grdColumn2.Width = new GridLength(10);
                testim.Margin = new Thickness(160, 160, 160, 160);
                printDialog.PrintVisual(testim, "Печать с помощью классов визуального уровня");

                grdColumn1.Width = new GridLength(420);
                grdColumn2.Width = new GridLength();
                testim.Margin = new Thickness(0,0,0,0);
                this.Height = 780;
                // Создать визуальный элемент для страницы
                //DrawingVisual visual = new DrawingVisual();

                //// Получить контекст рисования
                //using (DrawingContext dc = visual.RenderOpen())
                //{
                //    // Определить текст, который необходимо печатать
                //    FormattedText text = new FormattedText(lbDate.Content.ToString(),
                //        System.Globalization.CultureInfo.CurrentCulture,
                //        FlowDirection.LeftToRight,
                //        new Typeface("Calibri"), 20, Brushes.Black);

                //    // Указать максимальную ширину, в пределах которой выполнять перенос текста, 
                //    text.MaxTextWidth = printDialog.PrintableAreaWidth / 2;

                //    // Получить размер выводимого текста. 
                //    Size textSize = new Size(text.Width, text.Height);

                //    // Найти верхний левый угол, куда должен быть помещен текст. 
                //    double margin = 24;
                //    Point point = new Point(
                //        (printDialog.PrintableAreaWidth - textSize.Width) / 2 - margin,
                //        (printDialog.PrintableAreaHeight - textSize.Height) / 2 - margin);

                //    // Нарисовать содержимое, 
                //    dc.DrawText(text, point);


                //    // Добавить рамку (прямоугольник без фона). 
                //    dc.DrawRectangle(null, new Pen(Brushes.Black, 1),
                //        new Rect(margin, margin, printDialog.PrintableAreaWidth - margin * 2,
                //            printDialog.PrintableAreaHeight - margin * 2));
                //}

                // Напечатать визуальный элемент. 
            }

        }

        private void ExportToExcelAndCsv()
        {
            DataTable.SelectAllCells();
            DataTable.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, DataTable);
            String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            String result = (string)Clipboard.GetData(DataFormats.Text);
            DataTable.UnselectAllCells();
            System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"C:\Users\Somir\Desktop\somir.xls");
            file1.WriteLine(result.Replace(',', ' '));
            file1.Close();

            MessageBox.Show(" Exporting DataGrid data to Excel file created.xls");
        }
    }

    public class InfoTable : ObservableObject
    {
        private bool isWeekend;
        public bool IsWeekend
        {
            get { return isWeekend; }
            set { isWeekend = value; OnPropertyChanged(); }
        }

        public static double totalSum;
        public double TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; OnPropertyChanged(); }
        }

        public static double KmToLitreRate = 0.11;
        private short kilometers;
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                if (date.CheckSaturday() || date.CheckSunday()) IsWeekend = true;
                OnPropertyChanged();
            }
        }
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
        public short Kilometers
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

        public static bool CheckSaturday(this DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday);

        }

        public static bool CheckSunday(this DateTime date)
        {
            
            return (date.DayOfWeek == DayOfWeek.Sunday);
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
