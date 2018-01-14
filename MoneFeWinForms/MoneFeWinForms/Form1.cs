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
        private MoneFyFormsBuild Monefy;
        private int x;
        public MoneFy()
        {
            x = 10000;
            InitializeComponent();
            Monefy = new MoneFyFormsBuild(Languages.EN);
            LoadLang();
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

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            foreach (var item in Monefy.Operations)
            {
                foreach (var operaiton in item.Value)
                {
                    MessageBox.Show(
                        $"{operaiton.Account}  {operaiton.AccCurrency}  {operaiton.Category}  {operaiton.Value}");
                }
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = "";
            tbAmount.Text += "0";
        }

        private void btnClothes_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnClothes);
            pbSelectedCategoryImg.Image = btnClothes.Image;
        }

        private void btnEatingOut_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnEatingOut);
            pbSelectedCategoryImg.Image = btnEatingOut.Image;
        }

        private void btnEntertainment_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnEntertainment);
            pbSelectedCategoryImg.Image = btnEntertainment.Image;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnFood);
            pbSelectedCategoryImg.Image = btnFood.Image;
        }

        private void btnGifts_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnGifts);
            pbSelectedCategoryImg.Image = btnGifts.Image;
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnCommunication);
            pbSelectedCategoryImg.Image = btnCommunication.Image;
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnHealth);
            pbSelectedCategoryImg.Image = btnHealth.Image;
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnHouse);
            pbSelectedCategoryImg.Image = btnHouse.Image;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnSport);
            pbSelectedCategoryImg.Image = btnSport.Image;
        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnTaxi);
            pbSelectedCategoryImg.Image = btnTaxi.Image;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            lbAddedCategory.Text = toolTipCategory.GetToolTip(btnTransport);
            pbSelectedCategoryImg.Image = btnTransport.Image;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (tbAmount.TextLength != 0)
                tbAmount.Text = tbAmount.Text.Remove(tbAmount.TextLength - 1);
            if (tbAmount.Text == string.Empty)
                tbAmount.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!tbAmount.Text.Contains(",") && tbAmount.TextLength != 0)
                tbAmount.Text += ",";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (Monefy.Operations.ContainsKey(DateTime.Now.Date))
                Monefy.Operations[DateTime.Now.Date].Add(new MoneyOperation(Currency.AZN, "test", "test", "test", Convert.ToDouble(tbAmount.Text)));
            else
                Monefy.Operations.Add(DateTime.Now.Date, new List<MoneyOperation>() { new MoneyOperation(Currency.AZN, "salanm", "account", "uiwqgfouigwqof", 2321.5) });
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            try
            {
                if (tbAmount.TextLength > 0)
                value = Convert.ToDouble(tbAmount.Text);
            }
            catch (Exception)
            {
                tbAmount.Text = "0";
            }
            int dot = tbAmount.Text.IndexOf(",");

            if (tbAmount.TextLength > 0 && value > 999999999.99 || dot > 0 && tbAmount.TextLength - dot == 4)
            {
                tbAmount.Text = tbAmount.Text.Remove(tbAmount.TextLength - 1);
                tbAmount.SelectionStart = tbAmount.TextLength;
            }
        }

        private void tbAmount_Enter(object sender, EventArgs e)
        {
            if (tbAmount.Text == "0")
                tbAmount.Text = string.Empty;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
        }
    }
}
