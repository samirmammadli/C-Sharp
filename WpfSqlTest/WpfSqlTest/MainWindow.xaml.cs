using System;
using System.Collections.Generic;
using System.Data;
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
using WpfSqlTest._1gb_librarysqlDataSetTableAdapters;

namespace WpfSqlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollectionViewSource authorsViewSource { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _1gb_librarysqlDataSet _1gb_librarysqlDataSet2 = ((_1gb_librarysqlDataSet)(this.FindResource("_1gb_librarysqlDataSet")));
            // Load data into the table Authors. You can modify this code as needed.
            AuthorsTableAdapter _1gb_librarysqlDataSetAuthorsTableAdapter = new AuthorsTableAdapter();
            _1gb_librarysqlDataSetAuthorsTableAdapter.Fill(_1gb_librarysqlDataSet2.Authors);
            authorsViewSource = ((CollectionViewSource)(this.FindResource("authorsViewSource")));
            authorsViewSource.View.MoveCurrentToFirst();
        }

        private void BtnAddToAuthors_Click(object sender, RoutedEventArgs e)
        {
            var author = new AuthorsTableAdapter();
            author.Insert(tbFirstName.Text, tbLastName.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var author = new AuthorsTableAdapter();
            //string[] fields = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    fields[i] = (authorsDataGrid.SelectedValue as DataRowView).Row.Table.Columns[i].ToString();
            //}
            //author.Delete()

            


        }
    }
}
