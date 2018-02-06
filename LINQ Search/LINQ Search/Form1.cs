using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;

namespace LINQ_Search
{
    
    public partial class Form1 : Form
    {
        private Search search;
        private BindingListView<User> BindingList;

        public Form1()
        {
            InitializeComponent();
            search = new Search();
            BindingList = new BindingListView<User>(search.Users);
            dataGridView1.DataSource = BindingList;
            cbGender.SelectedIndex = 0;
        }

        private void SearchUser()
        {
            var list = (from user in search.Users
                       where user.Name.IndexOf(tbName.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.LastName.IndexOf(tbLastName.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.Country.IndexOf(tbCountry.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.City.IndexOf(tbCity.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.Company.IndexOf(tbCompany.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where cbGender.Text == "All" || user.Gender == cbGender.SelectedItem.ToString() 
                       select user).ToList();
            BindingList.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
        }
    }
}
