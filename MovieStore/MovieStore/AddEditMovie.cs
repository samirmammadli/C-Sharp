using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public partial class AddEditMovie : Form
    {
        private Image Image { get; set; }
        public Movie NewMovie { get; set; }
        public AddEditMovie(Movie movie)
        {

            NewMovie = movie;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var data = MovieDataDownloader.GetData(tbTitle.Text);
                tbTitle.Text = data[0];
                tbGenre.Text = data[1];
                tbType.Text = data[2];
                tbRuntime.Text = data[3];
                tbYear.Text = data[4];

                pbImage.Image = MovieDataDownloader.GetImage(data[5]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int.TryParse(tbYear.Text, out int year);
            NewMovie = new Movie(tbTitle.Text, tbGenre.Text,tbType.Text, tbRuntime.Text, year, cbViewed.Checked, pbImage.Image);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
