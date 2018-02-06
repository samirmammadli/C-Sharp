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
        private Dictionary<string, List<string>> CountriesCitiesList;

        public Form1()
        {
            InitializeComponent();
            search = new Search();
            CountriesCitiesList = new Dictionary<string, List<string>>();
            GetCountries();
            BindingList = new BindingListView<User>(search.Users);
            dataGridView1.DataSource = BindingList;
            cbGender.SelectedIndex = 0;
        }


        private void GetCountries()
        {

            CountriesCitiesList = search.Users.OrderBy(x=>x.Country).GroupBy(x => x.Country, y => y.City).ToDictionary(x=>x.Key, y=>y.OrderBy(z => z).ToList());
            var list = new List<string>();
            list.Add("All Countries");
            list.AddRange(CountriesCitiesList.Keys.ToList());
            cbCountries.DataSource = list;

            
        }


        private void SearchUser()
        {
            var list = (from user in search.Users
                       where user.Name.IndexOf(tbName.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.LastName.IndexOf(tbLastName.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where cbCountries.SelectedValue.ToString() == "All Countries" ||  user.Country.IndexOf(cbCountries.SelectedValue.ToString(), 0, StringComparison.OrdinalIgnoreCase) == 0
                       where cbCities.SelectedValue.ToString() == "All Cities" ||  user.City.IndexOf(cbCities.SelectedValue.ToString(), 0, StringComparison.OrdinalIgnoreCase) == 0
                       where user.Company.IndexOf(tbCompany.Text, 0, StringComparison.OrdinalIgnoreCase) == 0
                       where cbGender.Text == "All" || user.Gender == cbGender.SelectedItem.ToString()
                       select user).ToList();
            BindingList.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add("All Cities");
            if (cbCountries.SelectedValue.ToString() != "All Countries")
            list.AddRange(CountriesCitiesList[cbCountries.SelectedValue.ToString()]);
            cbCities.DataSource = list;
        }
    }
}
