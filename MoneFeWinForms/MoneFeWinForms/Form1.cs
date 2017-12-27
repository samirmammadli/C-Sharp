using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneFeWinForms
{
    public partial class MoneFy : Form
    {
        public MoneFy()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            chart1.Series["Categories"].Points.Add(rnd.Next(1, 150));
            //chart1.Series["Categories"].Points[0].AxisLabel = 3214.ToString();
            chart1.Series["Categories"].Points[0].LegendText = "Home";
            chart1.Series["Categories"].Points[0].IsValueShownAsLabel = true;
            chart1.Series["Categories"].Points.AddXY("Entertainment", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Sport", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Gift", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Car", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Aptek", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Taxi", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Fun", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Clothes", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Something", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("The elder", rnd.Next(1, 150));
            chart1.Series["Categories"].Points.AddXY("Other", rnd.Next(1, 150));

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit MoneFe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
