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
            try
            {
                store = DeserializeAndLoad.LoadSavedData("MovieStore.dat") as MovieStorage;
            }
            catch (Exception e)
            {
                store = new MovieStorage();
            }
            
            store.MovieCollectionChanged += RefreshDataGrid;


            bs = new BindingSource { DataSource = ConvertToDataTable(store.Movies) };
            dataGridView2.DataSource = bs;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            
            var viewed = new Dictionary<string, bool> { { "All", false} , { "Viewed", true }, { "Unviewed", false } }.ToList();

            cbViewed.DataSource = viewed;
            cbViewed.DisplayMember = "Key";
            cbViewed.ValueMember = "Value";
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
            string filter = $"Title LIKE '%{title}%' AND Type LIKE '{type}%' AND Genre LIKE '%{genre}%'";
            if (cbViewed.SelectedIndex != 0)
                filter += $" AND Viewed = {viewed}";
            if (int.TryParse(year, out int Year))
                filter += $" AND Year = {Year}";
            bs.Filter = filter;
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
            SortData(tbGenre.Text, tbTitle.Text, tbType.Text, tbYear.Text, (bool)cbViewed.SelectedValue);
           
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
            var addEdit = new AddEditMovie(this, OperationType.Add);
            addEdit.ShowDialog();
        }


        public void GetAddedMovieData(Movie movie, Image img)
        {
            store.AddMovie(movie, img);
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void GetEditedMovieData(Movie movie, Image img)
        {
            if (dataGridView2.Rows.Count > 0)
                store.EditMovie((int)dataGridView2.SelectedRows[0].Cells[1].Value,movie, img);
        }

        public Movie SendSelectedMovieData()
        {
            int id = (int)dataGridView2.SelectedRows[0].Cells[1].Value;
            return store.Movies.Find(x => x.MovieID == id);
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                var addEdit = new AddEditMovie(this, OperationType.Edit);
                addEdit.ShowDialog();
                addEdit.Dispose();
            }  
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count > 0)
            {
                int id = (int)dataGridView2.SelectedRows[0].Cells[1].Value;
                pbMovieImage.Image = null;
                store.DeleteMovie(id);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                DeserializeAndLoad.SaveData("MovieStore.dat", store);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    int id = (int)dataGridView2.SelectedRows[0].Cells[1].Value;
                    pbMovieImage.Image = null;
                    store.DeleteMovie(id);
                }
            }
            else if(e.KeyValue == 13)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    var addEdit = new AddEditMovie(this, OperationType.Edit);
                    addEdit.ShowDialog();
                    addEdit.Dispose();
                }
            }
        }
    }

}
