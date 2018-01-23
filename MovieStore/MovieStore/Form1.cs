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
        public Form1()
        {
            InitializeComponent();
            movies = new List<Movie>
            {
                new Movie("Terminator 2", "Fantastic", "Movie", "240", "1991", false),
                new Movie("Avatar", "Fantastic", "Movie", "240", "240", true)
            };
            //data = new BindingSource {DataSource = movies};

           // dataGridView2.DataSource = data;


        }

        private void SortData(string name)
        {
            var mov = (from item in movies
                where item.Title.Contains(name)
                select item).ToList();
            data = new BindingSource { DataSource = mov };
            dataGridView2.DataSource = data;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SortData(tbTitle.Text);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
