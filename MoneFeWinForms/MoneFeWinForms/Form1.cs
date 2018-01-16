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
        public MoneFy()
        {
            InitializeComponent();
            Monefy = new MoneFyFormsBuild(Languages.EN);
            Monefy.Accounts.Add(new Account(Currency.AZN, "Samir", 1250.50));
            cbAddAccCurrency.DataSource = Enum.GetValues(typeof(Currency));
            cbAddAccCurrency.SelectedItem = null;
            cbSelectAccount.DataSource = Monefy.Accounts;
            cbSelectAccount.SelectedItem = null;
            LoadLang();
            LoadImages();
        }

        private void LoadCategoriesChart()
        {
            //var summ = Monefy.Operations.Values.Select(x => x.Sum(u => u.Value)).Sum(y => y);
 
            var nese = Monefy.Operations.Where(x => x.Key >= DateTime.Now.Date).SelectMany(y => y.Value).ToList();
            var gew = nese;


            //var gew = Monefy.Operations.GroupBy(x => x.Key == DateTime.Now.Date).ToList();
            var gnom = nese.Sum(y => y.Value);
            
            Console.WriteLine(gnom);


            //foreach (var item in Monefy.Operations)
            //{
            //    foreach (var oper in item.Value)
            //    {
            //        chart1.Series["Categories"].Points.AddXY("", oper.Value);
            //        int index = chart1.Series["Categories"].Points.Count - 1;

            //        chart1.Series["Categories"].Points[index].LegendText = Monefy.Categories[oper.Category] + "  " + (oper.Value / 100).ToString("0.00%");
            //    }

            //}
        }
        private void LoadLang()
        {
            //Categories
            this.toolTipCategory.SetToolTip(this.btnCar, Monefy.Categories["cars"]);
            this.toolTipCategory.SetToolTip(this.btnClothes, Monefy.Categories["clothes"]);
            this.toolTipCategory.SetToolTip(this.btnCommunication, Monefy.Categories["communications"]);
            this.toolTipCategory.SetToolTip(this.btnEatingOut, Monefy.Categories["eating_out"]);
            this.toolTipCategory.SetToolTip(this.btnEntertainment, Monefy.Categories["entertainment"]);
            this.toolTipCategory.SetToolTip(this.btnFood, Monefy.Categories["food"]);
            this.toolTipCategory.SetToolTip(this.btnGifts, Monefy.Categories["gifts"]);
            this.toolTipCategory.SetToolTip(this.btnHealth, Monefy.Categories["health"]);
            this.toolTipCategory.SetToolTip(this.btnHouse, Monefy.Categories["house"]);
            this.toolTipCategory.SetToolTip(this.btnSport, Monefy.Categories["sports"]);
            this.toolTipCategory.SetToolTip(this.btnTaxi, Monefy.Categories["taxi"]);
            this.toolTipCategory.SetToolTip(this.btnTransport, Monefy.Categories["transport"]);
            //Interface
            this.toolTipCategory.ToolTipTitle = Monefy.Interface["category"] + ":";
            this.toolTipInterface.ToolTipTitle = "";
            this.languageToolStripMenuItem.Text = Monefy.Interface["language"];
            this.englishToolStripMenuItem.Text = Monefy.Interface["lang_english"];
            this.русскийToolStripMenuItem.Text = Monefy.Interface["lang_russian"];
            this.exitToolStripMenuItem.Text = Monefy.Interface["file"];
            this.exitToolStripMenuItem1.Text = Monefy.Interface["exit"];
            this.lbIncome.Text = Monefy.Interface["income"] + ":";
            this.lbOutcome.Text = Monefy.Interface["outcome"] + ":";
            this.btnAddCategory.Text = Monefy.Interface["add"];
            this.toolTipInterface.SetToolTip(this.btnAddAccount, Monefy.Interface["addNewAccount"]);
            this.lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            this.lbAddAccCurrency.Text = Monefy.Interface["currency"];
            this.lbSelectAccount.Text = Monefy.Interface["account"];
            this.cbSelectCategory.DataSource = Monefy.Categories.ToList();
            this.cbSelectCategory.DisplayMember = "Value";
            this.cbSelectCategory.ValueMember = "Key";
            this.cbSelectCategory.SelectedItem = null;
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
            
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "cars";



            pbSelectedCategoryImg.Image = btnCar.Image;
            pnlAddAmount.Visible = true;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //foreach (var item in Monefy.Operations)
            //{
            //    foreach (var operaiton in item.Value)
            //    {
            //        MessageBox.Show(
            //            $"{operaiton.AccountID}   {operaiton.AccCurrency}  {operaiton.Category}  {operaiton.Value}");
            //    }
            //}
            //chart1.Series["Categories"].Points[1].SetValueXY("Rombon", 1561651651);
            chart1.Series["Categories"].Points.Clear();
            LoadCategoriesChart();
            
            //foreach (var item in chart1.Series["Categories"].Points)
            //{
            //    if (item.XValue.ToString() == "Car")
            //        Console.WriteLine("Nawel");
            //}

            //Test();
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
            cbSelectCategory.SelectedValue = "clothes";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
             //btnClothes.Image;
        }

        private void btnEatingOut_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "eating_out";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnEatingOut.Image;
        }

        private void btnEntertainment_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "entertainment";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnEntertainment.Image;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "food";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnFood.Image;
        }

        private void btnGifts_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "gifts";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnGifts.Image;
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "communications";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnCommunication.Image;
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "health";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnHealth.Image;
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "house";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnHouse.Image;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "sports";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnSport.Image;
        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "taxi";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            pbSelectedCategoryImg.Image = btnTaxi.Image;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "transport";
            lbAddToCategory.Text = Monefy.Interface["addToCategory"];  
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
            if (Monefy.OperType == OperationType.Category)
            {
                for (int i = 0; i < 11500; i++)
                {
                    Currency curr;
                    Enum.TryParse(cbAddAccCurrency.SelectedText, out curr);
                    var operation = new MoneyOperation(curr, cbSelectCategory.SelectedValue.ToString(), 115, "Some note", Convert.ToDouble(tbAmount.Text));

                    if (Monefy.Operations.ContainsKey(DateTime.Now.Date))
                        Monefy.Operations[DateTime.Now.Date].Add(operation);
                    else
                        Monefy.Operations.Add(DateTime.Now.Date, new List<MoneyOperation>() { operation });
                }
                
            }
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
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if(tbAmount.Text == "0" && e.KeyChar != ',') tbAmount.Clear();
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
           
            
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            //pbSelectedCategoryImg.Image = Images[cbSelectCategory.SelectedValue.ToString()];
        }

        private void cbSelectCategory_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectCategory.SelectedItem == null)// || cbSelectCategory.SelectedItem.ToString() == @"[cars, Car]")
            {
                return;
            }
            else
                pbSelectedCategoryImg.Image = Images[cbSelectCategory.SelectedValue.ToString()];
        }
    }
}
