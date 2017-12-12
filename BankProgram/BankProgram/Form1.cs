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
    public partial class Form1 : Form
    {
        private Bank bank;
        public Form1()
        {
            bank = new Bank();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(DateTime.Now, 12321431, 98436951 , 50000 , CURRENCY.AZN);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CURRENCY cur = CURRENCY.AZN;
            if (cbCurrency.Text == "USD")
                cur = CURRENCY.USD;
            else if (cbCurrency.Text == "EUR")
                cur = CURRENCY.EUR;

            ClientMembership member = ClientMembership.Normal;
            if (cbMember.Text == "Gold")
                member = ClientMembership.Gold;
            else if (cbMember.Text == "Platinum")
                member = ClientMembership.Platinum;

                
            int age;
            int.TryParse(tbAge.Text, out age);
            bank.AddNewClient(tbName.Text, tbSurname.Text, age, tbPhone.Text, tbMail.Text, cur, chkbEnabled.Checked, member);
            bank.SaveData();
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
