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
        public BindingSource data;
        private List<Movie> movies;
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
                Random a = new Random();
            movies = new List<Movie>
            {
                new Movie("Terminator 2", "Fantastic", "Movie", "240", "1991", false),
                new Movie("Avatar", "Fantastic", "Movie", "240", "240", true)
            };

            for (int i = 0; i < 321412; i++)
            {
                movies.Add(new Movie("Avatar", "Fantastic", "Movie", "240", a.Next(0, 2020).ToString(), true));
            }

            SortData(tbGenre.Text, tbTitle.Text, tbType.Text, tbYear.Text);
            //data = new BindingSource {DataSource = movies};

            // dataGridView2.DataSource = data;


        }

        private void SortData(string genre, string title, string type, string year)
        {
            var mov = (from item in movies.Take(20)
                where item.Title.Contains(title, StringComparison.OrdinalIgnoreCase)
                where item.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)
                where item.Type.Contains(type, StringComparison.OrdinalIgnoreCase)
                where item.Year.Contains(year, StringComparison.OrdinalIgnoreCase)
                select item).ToList();
            bs = new BindingSource { DataSource = mov };
            dataGridView2.DataSource = bs;
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
