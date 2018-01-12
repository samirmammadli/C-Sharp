﻿using System;
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
        private MoneFyFormsBuild Monefy;
        private int x;
        public MoneFy()
        {
            x = 10000;
            InitializeComponent();
            Monefy = new MoneFyFormsBuild(Languages.EN);
            LoadLang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCategoriesChart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Monefy.Interface["exit_warning"], Monefy.Interface["exit"], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            русскийToolStripMenuItem.Checked = true;
            Monefy.ChangeLang(Languages.RU);
            LoadLang();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = true;
            русскийToolStripMenuItem.Checked = false;
            Monefy.ChangeLang(Languages.EN);
            LoadLang();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnCar);
            pbSelectedCategoryImg.Image = btnCar.Image;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //chart1.Series["Categories"].Points[1].SetValueXY("Rombon", 1561651651);
            chart1.Series["Categories"].Points.Clear();
            LoadCategoriesChart();
            foreach (var item in chart1.Series["Categories"].Points)
            {
                if (item.XValue.ToString() == "Car")
                    Console.WriteLine("Nawel");
            }
            //MessageBox.Show(chart1.Series["Categories"].Points[1].YValues[0].ToString());

        }

        private void tnAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }


        private void tbAmount_Enter(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
        }

        private void tbAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbAmount.Text);
            }
            catch (Exception)
            {
                tbAmount.Text = "0";
                //throw;
            }
        }
    }
}
