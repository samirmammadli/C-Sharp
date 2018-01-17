using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadImages();
            Monefy = new MoneFyFormsBuild(Languages.EN);
            //Monefy.Accounts.Add(new Account(Currency.AZN, "Samir", 1250.50));
            cbAddCategoryCurrency.DataSource = Enum.GetValues(typeof(Currency));
            cbAddAccCurr.DataSource = Enum.GetValues(typeof(Currency));
            cbAddCategoryCurrency.SelectedItem = null;
            cbAddAccCurr.SelectedItem = null;
            LoadAccList();
            RefreshData();
            LoadLang();
        }

        private void LoadAccList()
        {
            BindingSource bs = new BindingSource { DataSource = Monefy.Accounts };
            cbMainAccount.DataSource = null;
            cbMainAccount.DataSource = bs;
            cbMainAccount.DisplayMember = "AccName";

            cbSelectAccount.DataSource = null;
            cbSelectAccount.DataSource = Monefy.Accounts;
            cbSelectAccount.DisplayMember = "AccName";

        }

        private void RefreshData()
        {
            if (cbSelectAccount.Items.Count > 0) tbTotalBalance.Text = (cbMainAccount.SelectedValue as Account).Balance.ToString();
        }


        private void LoadCategoriesChart()
        {
            
            var nese = Monefy.Operations.Where(x => x.Key >= DateTime.Now.Date).SelectMany(y => y.Value).ToList();
            var outcome = nese.Where(x=>x.Type == OperationType.Category).Sum(y => y.Value);
            var income = nese.Where(x => x.Type == OperationType.Account).Sum(y => y.Value);
            var ds = nese.GroupBy(x => x.Category);

            lbIncomeBalanceValue.Text = income.ToString();
            lbOutcomeBalanceValue.Text = outcome.ToString();

            foreach (var item in ds)
            {
                //Console.WriteLine(item.Key);
                double value = item.Sum(x => x.Value);
                chart1.Series["Categories"].Points.AddXY("", value);
                int index = chart1.Series["Categories"].Points.Count - 1;

                chart1.Series["Categories"].Points[index].LegendText = Monefy.Categories[item.Key] + "  " + (value / outcome).ToString("0.00%");
            }

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
            this.lbAddCategoryCurrency.Text = Monefy.Interface["currency"];
            this.lbAddAccCurr.Text = Monefy.Interface["currency"];
            this.lbSelectAccount.Text = Monefy.Interface["account"];
            this.lbMainAccount.Text = Monefy.Interface["account"];
            this.lbAddCategoryNote.Text = Monefy.Interface["addNote"];
            this.lbAddAccBalance.Text = Monefy.Interface["balance"];
            this.lbTotalBalance.Text = Monefy.Interface["balance"];
            this.lbAccountName.Text = Monefy.Interface["accountName"];
            this.lbSelectRange.Text = Monefy.Interface["chooseDate"];
            this.cbSelectCategory.DataSource = Monefy.Categories.ToList();
            this.cbSelectCategory.DisplayMember = "Value";
            this.cbSelectCategory.ValueMember = "Key";
            this.pbSelectedCategoryImg.Image = Images[cbSelectCategory.SelectedValue.ToString()];

            string[] RangeItems = {Monefy.Interface["year"],
                Monefy.Interface["month"],
                Monefy.Interface["week"],
                Monefy.Interface["day"] };

            this.cbSelectRange.Items.Clear();
            this.cbSelectRange.Items.AddRange(RangeItems);
            this.cbSelectRange.SelectedIndex = 3;
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
            pnlAddAmount.Visible = true;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            chart1.Series["Categories"].Points.Clear();
            LoadCategoriesChart();
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
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "clothes";
        }

        private void btnEatingOut_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "eating_out";
        }

        private void btnEntertainment_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "entertainment";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "food";
        }

        private void btnGifts_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "gifts";
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "communications";
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "health";
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {

            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true; cbSelectCategory.SelectedValue = "house";
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "sports";
        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "taxi";
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            pnlAddAmount.Visible = true;
            cbSelectCategory.SelectedValue = "transport";
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
            
            var value = Convert.ToDouble(tbAmount.Text);
            if (Monefy.OperType == OperationType.Category)
            {

                Currency curr;
                Enum.TryParse(cbAddCategoryCurrency.SelectedText, out curr);
                var account = cbSelectAccount.SelectedValue as Account;
                
                var operation = new MoneyOperation(curr, cbSelectCategory.SelectedValue.ToString(), Convert.ToInt32(account.AccountID), tbAddCategoryNote.Text, value );
                account.Balance -= value;
                tbTotalBalance.Text = Monefy.Accounts[0].Balance.ToString();

                if (Monefy.Operations.ContainsKey(DateTime.Now.Date))
                    Monefy.Operations[DateTime.Now.Date].Add(operation);
                else
                    Monefy.Operations.Add(DateTime.Now.Date, new List<MoneyOperation>() { operation });
            }
            else
            {
                Currency curr;
                Enum.TryParse(cbAddAccCurr.SelectedText, out curr);
                Monefy.Accounts.Add(new Account(curr, tbAddAccName.Text, value));
                LoadAccList();
                RefreshData();
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
            Monefy.OperType = OperationType.Account;
        }

        private void cbSelectCategory_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbSelectCategory_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectCategory.Items.Count == 0)
            {
                return;
            }
            else
                pbSelectedCategoryImg.Image = Images[cbSelectCategory.SelectedValue.ToString()];
        }

        private void tbAmount_Leave(object sender, EventArgs e)
        {
            if (tbAmount.Text == string.Empty)
                tbAmount.Text = "0";
        }

        private void tbTotalBalance_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbTotalBalance.Text) < 0)
                tbTotalBalance.ForeColor = Color.Red;
            else
            {
                tbTotalBalance.ForeColor = Color.Green;
            }
        }

        private void cbMainAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
