using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Search
{
    public partial class Form1 : Form
    {
        private Search search;
        private BindingSource bs;

        public Form1()
        {
            InitializeComponent();
            search = new Search();
            bs = new BindingSource { DataSource = search.Users };
            dataGridView1.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void SearchUser()
        {

        }
    }
}
