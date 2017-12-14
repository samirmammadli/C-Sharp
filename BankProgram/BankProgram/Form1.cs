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
            cbSearchEnabled.SelectedIndex = cbSearchEnabled.Items.IndexOf("All");
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
            bank.AddNewClient(tbName.Text, tbSurname.Text, age, tbPhone.Text, tbMail.Text, cur, chkbEnabled.Checked, member);
            bank.SaveData();
            pnlRegEdit.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<BaseClient> clients = bank.SearchClients(tbSearchID.Text,tbSearchAcc.Text, tbSearchName.Text,tbSearchSurname.Text, tbSearchBalance.Text);

            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            for (int i = 0; i < bank.GetUsersData(clients).Length; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < bank.GetUsersData(clients)[i].Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = bank.GetUsersData(clients)[i][j];
                }
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
    }
}
