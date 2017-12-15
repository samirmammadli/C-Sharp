using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProgram
{
    public partial class BankApplication : Form
    {
        private Bank bank;
        public BankApplication()
        {
            bank = new Bank();
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CURRENCY cur = EnumConverter.StringToCurrency(cbCurrency.Text);

            ClientMembership member = ClientMembership.Normal;
            if (cbMember.Text == "Gold")
                member = ClientMembership.Gold;
            else if (cbMember.Text == "Platinum")
                member = ClientMembership.Platinum;

                
            int age;
            int.TryParse(tbAge.Text, out age);
            decimal.TryParse(tbSetBalance.Text, out decimal blnc);
            try
            {
                bank.AddNewClient(tbName.Text, tbSurname.Text, age, tbPhone.Text, tbMail.Text, cur, chkbEnabled.Checked, member, blnc);
                bank.SaveData();
                pnlRegEdit.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<BaseClient> clients = bank.SearchClients(tbSearchID.Text, tbSearchAcc.Text, tbSearchName.Text, tbSearchSurname.Text, tbSearchBalance.Text);
            for (int i = 0; i < clients.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = clients[i].UserID;
                dataGridView1.Rows[i].Cells[1].Value = clients[i].Account;
                dataGridView1.Rows[i].Cells[2].Value = clients[i].Name;
                dataGridView1.Rows[i].Cells[3].Value = clients[i].Surname;
                dataGridView1.Rows[i].Cells[4].Value = clients[i].Phone;
                dataGridView1.Rows[i].Cells[5].Value = clients[i].Mail;
                dataGridView1.Rows[i].Cells[6].Value = clients[i].Balance;
                dataGridView1.Rows[i].Cells[7].Value = clients[i].Currency;
                dataGridView1.Rows[i].Cells[8].Value = clients[i].Enabled;
            }
        }

        private void PanelsVisibility(bool visible)
        {
            pnlAccountProp.Visible = visible;
            pnlRegEdit.Visible = visible;
            pnlSearch.Visible = visible;
        }

        private void btnAccountProp_Click(object sender, EventArgs e)
        {
            pnlAccountProp.Visible = !pnlAccountProp.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlRegEdit.Visible = true;
        }

        private void searchClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlSearch.Visible = !pnlSearch.Visible;
        }

        private void pnlSearch_VisibleChanged(object sender, EventArgs e)
        {
            tbSearchName.Clear();
            tbSearchSurname.Clear();
            tbSearchAcc.Clear();
            tbSearchBalance.Clear();
            tbSearchID.Clear();
            tbSearchBalance.Clear();
        }

        private void pnlRegEdit_VisibleChanged(object sender, EventArgs e)
        {
            tbName.Clear();
            tbSurname.Clear();
            tbPhone.Clear();
            tbMail.Clear();
            tbAge.Clear();
            tbSetBalance.Clear();
        }
    }
}
