﻿using System;
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
        private TransactionType? currentTransType;
        public BankApplication()
        {
            bank = new Bank();
            currentTransType = null;
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
                bank.SaveClients();
                pnlRegEdit.Visible = false;
                pnlAccountProp.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridClients.Rows.Clear();
            List<BaseClient> clients = bank.SearchClients(tbSearchID.Text, tbSearchAcc.Text, tbSearchName.Text, tbSearchSurname.Text, tbSearchBalance.Text);
            for (int i = 0; i < clients.Count; i++)
            {
                dataGridClients.Rows.Add();
                dataGridClients.Rows[i].Cells[0].Value = clients[i].UserID;
                dataGridClients.Rows[i].Cells[1].Value = clients[i].Account;
                dataGridClients.Rows[i].Cells[2].Value = clients[i].Name;
                dataGridClients.Rows[i].Cells[3].Value = clients[i].Surname;
                dataGridClients.Rows[i].Cells[4].Value = clients[i].Phone;
                dataGridClients.Rows[i].Cells[5].Value = clients[i].Mail;
                dataGridClients.Rows[i].Cells[6].Value = clients[i].Balance;
                dataGridClients.Rows[i].Cells[7].Value = clients[i].Currency;
                dataGridClients.Rows[i].Cells[8].Value = clients[i].Enabled;
            }
        }

        private void PanelsVisibility(bool visible)
        {
            pnlTransaction.Visible = visible;
            pnlAccountProp.Visible = visible;
            pnlRegEdit.Visible = visible;
            pnlClientsSearch.Visible = visible;
            pnlTransSearch.Visible = visible;
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
            pnlClientsSearch.Visible = !pnlClientsSearch.Visible;
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

        private void btnTransSearch_Click(object sender, EventArgs e)
        {
            dataGridTrans.Rows.Clear();
            List<Transaction> transactions = bank.SearcTransactions("", typeof(Transaction), "", "" );
            int transtype;
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i] is DepositTrans) transtype = 3;
                else if (transactions[i] is WithdrawTran) transtype = 4;
                else transtype = 5;
                dataGridTrans.Rows.Add();
                dataGridTrans.Rows[i].Cells[0].Value = transactions[i]._time;
                dataGridTrans.Rows[i].Cells[1].Value = transactions[i]._userId;
                dataGridTrans.Rows[i].Cells[2].Value = transactions[i].account;
                dataGridTrans.Rows[i].Cells[3].Value = string.Empty; 
                dataGridTrans.Rows[i].Cells[4].Value = string.Empty; 
                dataGridTrans.Rows[i].Cells[5].Value = string.Empty;
                dataGridTrans.Rows[i].Cells[transtype].Value = transactions[i].GetType().ToString();
                dataGridTrans.Rows[i].Cells[transtype].Value = (transactions[i] as TransferTran)?._transferTo;
                dataGridTrans.Rows[i].Cells[7].Value = transactions[i]._amount;
                dataGridTrans.Rows[i].Cells[8].Value = transactions[i]._currency;
                dataGridTrans.Rows[i].Cells[9].Value = transactions[i]._charge;
                dataGridTrans.Rows[i].Cells[10].Value = transactions[i]._totalAmount;
                dataGridTrans.Rows[i].Cells[11].Value = transactions[i]._totalCur;
            }
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            currentTransType = TransactionType.Withdraw;
            pnlTransaction.Visible = true;
        }

        private void btnTransSend_Click(object sender, EventArgs e)
        {
            try
            {
                switch (currentTransType)
                {
                    case TransactionType.Withdraw:
                        bank.Withdraw(tbTransFromAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                    case TransactionType.Deposit:
                        bank.Deposit(tbTransFromAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                    case TransactionType.Transfer:
                        bank.Transfer(tbTransFromAcc.Text, tbTransToAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            currentTransType = null;
        }

        private void pnlTransaction_VisibleChanged(object sender, EventArgs e)
        {
            tbTransFromAcc.Enabled = pnlTransaction.Visible;
            tbTransToAcc.Enabled = pnlTransaction.Visible;
            tbTransAmount.Enabled = pnlTransaction.Visible;
            cbTransCur.Enabled = pnlTransaction.Visible;
            if (pnlTransaction.Visible)
                tbTransToAcc.Enabled = currentTransType == TransactionType.Transfer;
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            currentTransType = TransactionType.Deposit;
            pnlTransaction.Visible = true;
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            currentTransType = TransactionType.Transfer;
            pnlTransaction.Visible = true;
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlTransaction.Visible = false;
        }

        private void allTransacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlTransSearch.Visible = true;
        }
    }
}
