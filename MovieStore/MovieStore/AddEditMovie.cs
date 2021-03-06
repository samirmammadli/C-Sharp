﻿using System;
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
    public partial class AddEditMovieForm : Form
    {
        private Form1 Parent { get; set; }
        private OperationType Type { get; set; }
        public AddEditMovieForm(Form1 parent, OperationType type)
        {
            InitializeComponent();
            Parent = parent;
            Type = type;
            if (type == OperationType.Edit)
            {
                this.Text = "Edit movie";
                LoadMovie();
            }
            else
                this.Text = "Add movie";

            cbType.Items.AddRange(new string[] { "movie", "series", "episode" });
            cbType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == string.Empty)
            {
                MessageBox.Show("Title can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var data = MovieDataDownloader.GetData(tbTitle.Text);
                tbTitle.Text = data[0];
                tbGenre.Text = data[1];
                cbType.SelectedItem = data[2];
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
            if (tbTitle.Text == string.Empty)
            {
                MessageBox.Show("Title can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(tbYear.Text, out int year);
            if (Type == OperationType.Add)
                Parent.GetAddedMovieData(new Movie(tbTitle.Text, tbGenre.Text, cbType.SelectedItem.ToString(), tbRuntime.Text, year, cbViewed.Checked), pbImage.Image);
            else 
                Parent.GetEditedMovieData(new Movie(tbTitle.Text, tbGenre.Text, cbType.SelectedItem.ToString(), tbRuntime.Text, year, cbViewed.Checked), pbImage.Image);
            DialogResult = DialogResult.OK;
        }

        private void LoadMovie()
        {
            Movie movie = Parent.SendSelectedMovieData();
            tbGenre.Text = movie.Genre;
            tbTitle.Text = movie.Title;
            tbRuntime.Text = movie.Runtime;
            cbType.SelectedText = movie.Type;
            tbYear.Text = movie.Year.ToString();
            pbImage.Image = movie.MovieImage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            var result = ofdLoadImage.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    pbImage.Image = null;
                    pbImage.Load(ofdLoadImage.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }
    }
}
