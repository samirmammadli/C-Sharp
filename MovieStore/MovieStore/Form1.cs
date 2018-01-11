using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
                new Movie("Terminator 2", "Fantastic", "Movie", 240, 1991),
                new Movie("Avatar", "Fantastic", "Movie", 280, 2008)
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

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            e.Handled = (!Char.IsDigit(key) && key != 8);
        }

        private void tbYear_Leave(object sender, EventArgs e)
        {
            if (tbYear.Text.Length != 4)
            {
                errorProvider1.SetError(tbYear, "Wrong year!");
            }
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void tbYear_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbYear_Enter(object sender, EventArgs e)
        {

        }
    }

}
