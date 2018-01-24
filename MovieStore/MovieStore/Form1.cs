using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public partial class Form1 : Form
    {

        private BindingSource data;
        private List<Movie> movies;
        private BindingSource bs;
        private MovieStore store;
        public Form1()
        {
            InitializeComponent();
                Random a = new Random();
            store = new MovieStore();
            movies = new List<Movie>
            {
                new Movie("Terminator 2", "Fantastic", "Movie", 240, 1991, false),
                new Movie("Avatar", "Fantastic", "Movie", 300, 2008, true)
            };

            store.AddMovie(new Movie("Terminator 2", "Fantastic", "Movie", 240, 1991, false));
            store.AddMovie(new Movie("Avatar2", "Fantastic", "Movie", 300, 2008, false));
            store.AddMovie(new Movie("Lethal Weapon", "Action film", "Movie", 180, 1992, false));
            store.AddMovie(new Movie("Fantastic four", "Fantastic", "Movie", 190, 2004, false));
            store.AddMovie(new Movie("Millionare", "Drama", "Movie", 110, 1991, false));
            store.AddMovie(new Movie("Game of Thrones", "Fantastic", "Serial", 65, 2017, false));

            DataView dw = new DataView(ConvertToDataTable(store.Movies));
            bs = new BindingSource();
            bs.DataSource = dw;
            dataGridView2.DataSource = bs;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;


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

        private void SortData(string genre, string title, string type, string year)
        {
            //temp = (from item in movies
            //        where item.Title.Contains(title, StringComparison.OrdinalIgnoreCase)
            //        where item.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)
            //        where item.Type.Contains(type, StringComparison.OrdinalIgnoreCase)
            //        where (year == string.Empty || item.Year == year)
            //        select item).Take(20).ToList();
            //bs?.ResetBindings(false);

            //if (int.Parse(year))



            if (!int.TryParse(year, out int Year))
                bs.Filter = $"Title LIKE '{title}%' AND Type LIKE '{type}%'";
            else
                bs.Filter = $"Title LIKE '{title}%' AND Type LIKE '{type}%' AND Year = {Year}";


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            SortData(tbGenre.Text, tbTitle.Text, tbType.Text, tbYear.Text);
           
        }
    }

}
