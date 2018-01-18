using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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
            Monefy.AccountsCountChanged += LoadAccList;
            Monefy.AccountsCountChanged += RefreshData;
            Monefy.OperationAdded += LoadCategoriesChart;
            Monefy.OperationAdded += RefreshData;
            Monefy.BalanceChanged += RefreshData;
            RefreshData();
            LoadAccList();
            LoadLang();
            CheckForCurrentLanguage();
            LoadCurrencyComboBoxes();
            ButtonsEventAdd();
        }

        private void ButtonsEventAdd()
        {
            btnCar.Click += CheckAccountExist;
            btnClothes.Click += CheckAccountExist;
            btnEatingOut.Click += CheckAccountExist;
            btnEntertainment.Click += CheckAccountExist;
            btnFood.Click += CheckAccountExist;
            btnGifts.Click += CheckAccountExist;
            btnCommunication.Click += CheckAccountExist;
            btnHealth.Click += CheckAccountExist;
            btnHouse.Click += CheckAccountExist;
            btnSport.Click += CheckAccountExist;
            btnTaxi.Click += CheckAccountExist;
            btnTransport.Click += CheckAccountExist;
            btnMainEditAcc.Click += CheckAccountExist;
            btnCharge.Click += CheckAccountExist;
            btnAdd.Click += CheckAccountExist;
        }

        private void LoadAccList()
        {
            BindingSource bs = new BindingSource { DataSource = Monefy.Accounts };
            cbMainAccount.DataSource = null;
            cbMainAccount.DataSource = bs;
            cbMainAccount.DisplayMember = "AccName";

            cbSelectAccount.DataSource = null;
            cbSelectAccount.DataSource = bs;
            cbSelectAccount.DisplayMember = "AccName";

            cbEditAccAcc.DataSource = null;
            cbEditAccAcc.DataSource = bs;
            cbEditAccAcc.DisplayMember = "AccName";

            cbAddToBalanceAcc.DataSource = null;
            cbAddToBalanceAcc.DataSource = bs;
            cbAddToBalanceAcc.DisplayMember = "AccName";
            //var formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("form.bin", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, Monefy);
            //}

            //var formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("form.bin", FileMode.Open))
            //{
            //    Console.WriteLine(fs.Name);
            //    Monefy = formatter.Deserialize(fs) as MoneFyFormsBuild;
            //}

        }

        private void RefreshData()
        {
            var acc = (cbMainAccount.SelectedValue as Account);
            tbTotalBalance.Text = (cbMainAccount.Items.Count > 0) ? acc.Balance.ToString() : "0";
            lbTotalBalance.Text = (cbMainAccount.Items.Count > 0) ? $"{Monefy.Interface["balance"]}  {acc.AccCurrency}" : Monefy.Interface["balance"];

        }

        private void CheckForCurrentLanguage()
        {
            if (Monefy.Language == Languages.EN)
            {
                russianToolStripMenuItem.Checked = false;
                englishToolStripMenuItem.Checked = true;
            }
            else if (Monefy.Language == Languages.RU)
            {
                russianToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            }
        }

        private void LoadCategoriesChart()
        {
            var date = DateTime.Now;
            int range = 0;
            if (cbSelectRange.SelectedIndex == 0)
                range = 365;
            else if (cbSelectRange.SelectedIndex == 1)
                range = 31;
            else if (cbSelectRange.SelectedIndex == 2)
                range = 7;

            var list = Monefy.Operations.Where(x => (date.Date - x.Key.Date).Days <= range).SelectMany(y => y.Value).ToList();
            var outcome = list.Where(x=>x.Type == OperationType.Category).Sum(y => y.Value);
            var income = list.Where(x => x.Type == OperationType.Account || x.Type == OperationType.AddBalance).Sum(y => y.Value);
            var sortedByCategory = list.Where(y=> y.Type == OperationType.Category).GroupBy(x => x.Category);

            lbIncomeBalanceValue.Text = income.ToString();
            lbOutcomeBalanceValue.Text = outcome.ToString();

            chart1.Series["Categories"].Points.Clear();
            foreach (var item in sortedByCategory)
            {
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
            this.russianToolStripMenuItem.Text = Monefy.Interface["lang_russian"];
            this.exitToolStripMenuItem.Text = Monefy.Interface["file"];
            this.exitToolStripMenuItem1.Text = Monefy.Interface["exit"];
            this.lbIncome.Text = Monefy.Interface["income"] + ":";
            this.lbOutcome.Text = Monefy.Interface["outcome"] + ":";
            this.btnAddCategory.Text = Monefy.Interface["add"];
            this.toolTipInterface.SetToolTip(this.btnAddAccount, Monefy.Interface["addNewAccount"]);
            this.tbAddAccountAddNewAcc.Text = Monefy.Interface["addNewAccount"];
            this.lbAddToCategory.Text = Monefy.Interface["addToCategory"];
            this.lbAddCategoryCurrency.Text = Monefy.Interface["currency"];
            this.lbEditAccCurrency.Text = Monefy.Interface["currency"];
            this.lbAddAccCurr.Text = Monefy.Interface["currency"];
            this.lbSelectAccount.Text = Monefy.Interface["account"];
            this.lbMainAccount.Text = Monefy.Interface["account"];
            this.lbEditAccAcc.Text = Monefy.Interface["account"];
            this.lbAddToBalanceAcc.Text = Monefy.Interface["account"];
            this.lbAddCategoryNote.Text = Monefy.Interface["addNote"];
            this.lbAddToBalanceNote.Text = Monefy.Interface["addNote"];
            this.lbAddAccBalance.Text = Monefy.Interface["balance"];
            this.lbAccountName.Text = Monefy.Interface["accountName"];
            this.lbSelectRange.Text = Monefy.Interface["chooseDate"];
            this.lbAddCategoryDate.Text = Monefy.Interface["date"];
            this.lbAddToBalanceDate.Text = Monefy.Interface["date"];
            this.btnEditAccSave.Text = Monefy.Interface["save"];
            this.btnMainEditAcc.Text = Monefy.Interface["edit"];
            this.btnEditAccCancel.Text = Monefy.Interface["cancel"];
            this.btnAddCategoryCancel.Text = Monefy.Interface["cancel"];
            this.btnEditAccDelete.Text = Monefy.Interface["delete"];
            this.cbSelectCategory.DataSource = Monefy.Categories.ToList();
            this.cbSelectCategory.DisplayMember = "Value";
            this.cbSelectCategory.ValueMember = "Key";
            this.pbSelectedCategoryImg.Image = Images[cbSelectCategory.SelectedValue.ToString()];
            lbTotalBalance.Text = (cbMainAccount.Items.Count > 0) ? $"{Monefy.Interface["balance"]}  {(cbMainAccount.SelectedItem as Account).AccCurrency}" : Monefy.Interface["balance"];

            string[] RangeItems = {Monefy.Interface["year"],
                Monefy.Interface["month"],
                Monefy.Interface["week"],
                Monefy.Interface["day"] };

            this.cbSelectRange.Items.Clear();
            this.cbSelectRange.Items.AddRange(RangeItems);
            this.cbSelectRange.SelectedIndex = 3;
            
            LoadCategoriesChart();
        }

        private void LoadCurrencyComboBoxes()
        {
            cbAddCategoryCurrency.DataSource = Enum.GetValues(typeof(Currency));
            cbAddAccCurr.DataSource = Enum.GetValues(typeof(Currency));
            cbEditAccCurrency.DataSource = Enum.GetValues(typeof(Currency));
            cbAddToBalanceCurr.DataSource = Enum.GetValues(typeof(Currency));
        }

        private void PanelsVisibility(bool visible)
        {
            pnlAddToCategory.Visible = visible;
            pnlAddToBalance.Visible = visible;
            pnlEditAccount.Visible = visible;
            pnlAddAcount.Visible = visible;
            pnlAddAmount.Visible = visible;
            pnlMain.Visible = visible;
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
            russianToolStripMenuItem.Checked = true;
            Monefy.ChangeLang(Languages.RU);
            LoadLang();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = true;
            russianToolStripMenuItem.Checked = false;
            Monefy.ChangeLang(Languages.EN);
            LoadLang();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "cars";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
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
            cbSelectCategory.SelectedValue = "clothes";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnEatingOut_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "eating_out";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnEntertainment_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "entertainment";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "food";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnGifts_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "gifts";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "communications";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "health";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {

            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "house";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            cbSelectCategory.SelectedValue = "sports";
            Monefy.OperType = OperationType.Category;
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "taxi";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "transport";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
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
                
                var account = cbSelectAccount.SelectedValue as Account;
                Currency curr = (Currency)cbAddCategoryCurrency.SelectedValue;
                var operation = new MoneyOperation(curr, cbSelectCategory.SelectedValue.ToString(), account.AccName, Convert.ToInt32(account.AccountID), tbAddCategoryNote.Text, value);
                account.Balance -= value;

                Monefy.AddOperation(dtpAddCategory.Value.Date, operation);
            }
            else if (Monefy.OperType == OperationType.Account)
            {
                Currency curr = (Currency) cbAddAccCurr.SelectedValue;
                Monefy.AddAccount(new Account(curr, tbAddAccName.Text, value));
                var operation = new MoneyOperation(curr, "newAccountAdd", tbAddAccName.Text, Monefy.GetLastAddedAccountID(),  tbAddAccName.Text, value, OperationType.Account);
                Monefy.AddOperation(DateTime.Now.Date, operation);
            }
            else if (Monefy.OperType == OperationType.AddBalance)
            {
                Currency curr = (Currency)cbAddToBalanceCurr.SelectedValue;
                var account = cbAddToBalanceAcc.SelectedValue as Account;
                var operation = new MoneyOperation(curr, "balanceIncrease", account.AccName, Convert.ToInt32(account.AccountID), tbAddToBalanceNote.Text, value, OperationType.AddBalance);
                Monefy.AddOperation(dtpAddToBalance.Value.Date, operation);
                Monefy.IncreaseBalanceToAccount(account.AccountID, value);
            }

            PanelsVisibility(false);
            pnlMain.Visible = true;
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
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddAcount.Visible = true;
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

        private void btnAddCategoryCancel_Click(object sender, EventArgs e)
        {
                PanelsVisibility(false);
                pnlMain.Visible = true;
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.Category;
            cbSelectCategory.SelectedValue = "cars";
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToCategory.Visible = true;
        }

        private void btnMainEditAcc_Click(object sender, EventArgs e)
        {
            if (cbMainAccount.SelectedIndex >= 0)
            {
                cbEditAccAcc.SelectedIndex = cbMainAccount.SelectedIndex;
                var acc = cbEditAccAcc.SelectedItem as Account;
                if (acc != null) cbEditAccCurrency.SelectedItem = acc.AccCurrency;

                PanelsVisibility(false);
                pnlEditAccount.Visible = true;
            }
        }

        private void btnEditAccCancel_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlMain.Visible = true;
        }

        private void btnEditAccSave_Click(object sender, EventArgs e)
        {
            var acc = cbEditAccAcc.SelectedItem as Account;
            acc.AccCurrency = (Currency)cbEditAccCurrency.SelectedItem;
            MessageBox.Show(Monefy.Interface["accountEdited"], Monefy.Interface["successOperation"], MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            PanelsVisibility(false);
            pnlMain.Visible = true;
        }

        private void btnEditAccDelete_Click(object sender, EventArgs e)
        {
            var acc = cbEditAccAcc.SelectedItem as Account;
            Monefy.DeleteAccount(acc.AccountID);
            Monefy.DeleteOperations(acc.AccountID);
            MessageBox.Show(Monefy.Interface["accountDeleted"], Monefy.Interface["successOperation"], MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            PanelsVisibility(false);
            pnlMain.Visible = true;
        }

        private void cbSelectRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategoriesChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Monefy.OperType = OperationType.AddBalance;
            PanelsVisibility(false);
            pnlAddAmount.Visible = true;
            pnlAddToBalance.Visible = true;
        }

        private void CheckAccountExist(object sender, EventArgs e)
        {
            if (Monefy?.Accounts.Count <= 0)
            {
                btnAddAccount_Click(sender, e);
            }
        }

        private void btnMainExportCSV_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            int range = 0;
            if (cbSelectRange.SelectedIndex == 0)
                range = 365;
            else if (cbSelectRange.SelectedIndex == 1)
                range = 31;
            else if (cbSelectRange.SelectedIndex == 2)
                range = 7;

            var list = Monefy.Operations.Where(x => (date.Date - x.Key.Date).Days <= range).SelectMany(y => y.Value).ToList();
            string patch = @"C:\Users\Somir\Desktop\monefy\samir.csv";
            File.WriteAllText(patch, $"{Monefy.Interface["account"]};{Monefy.Interface["category"]};{Monefy.Interface["summ"]};{Monefy.Interface["currency"]};{Monefy.Interface["comment"]}" + Environment.NewLine, Encoding.UTF8);
            foreach (var item in list)
            {
                if (item.Type == OperationType.Account)
                 item.WriteCSV(patch, Monefy.Interface[item.Category]);
                else if (item.Type == OperationType.Category)
                    item.WriteCSV(patch, Monefy.Categories[item.Category]);
                else
                    item.WriteCSV(patch, Monefy.Interface[item.Category]);

            }
        }
    }
}
