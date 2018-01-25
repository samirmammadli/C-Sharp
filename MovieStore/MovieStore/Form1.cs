using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public partial class Form1 : Form
    {
        private BindingSource bs;
        private MovieStorage store;
        public Form1()
        {
            InitializeComponent();
                Random a = new Random();
            store = new MovieStorage();

            store.AddMovie(new Movie("Terminator 2", "Fantastic", "Movie", "240", 1991, false));
            store.AddMovie(new Movie("Avatar2", "Fantastic", "Movie", "300", 2008, false));
            store.AddMovie(new Movie("Lethal Weapon", "Action film", "Movie", "180", 1992, false));
            store.AddMovie(new Movie("Fantastic four", "Fantastic", "Movie", "190", 2004, false));
            store.AddMovie(new Movie("Millionare", "Drama", "Movie", "110", 1991, false));
            store.AddMovie(new Movie("Game of Thrones", "Fantastic", "Serial", "65", 2017, false));


            bs = new BindingSource { DataSource = ConvertToDataTable(store.Movies) };
            dataGridView2.DataSource = bs;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;

            store.MovieCollectionChanged += RefreshDataGrid;


        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        private void SortData(string genre, string title, string type, string year, bool viewed)
        {
            
            

            if (!int.TryParse(year, out int Year))
                bs.Filter = $"Title LIKE '{title}%' AND Type LIKE '{type}%' AND Viewed = {viewed}";
            else
                bs.Filter = $"Title LIKE '{title}%' AND Type LIKE '{type}%' AND Year = {Year} AND Viewed = {viewed}";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RefreshDataGrid()
        {
            bs.DataSource = ConvertToDataTable(store.Movies);
            bs.ResetBindings(false);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            SortData(tbGenre.Text, tbTitle.Text, tbType.Text, tbYear.Text, cbSearchViewed.Checked);
           
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridView2.SelectedRows.Count > 0)
            {
                pbMovieImage.Image = dataGridView2.SelectedRows[0].Cells[0].Value as Bitmap;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addEdit = new AddEditMovie(this);
            addEdit.ShowDialog();

        }


        public void GetAddedMovieData(Movie movie, Image img)
        {
            store.AddMovie(movie, img);
        }
    }

}
