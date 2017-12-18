using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProgram
{
    public partial class BankApplication : Form
    {
        private Bank _bank;
        private TransactionType? currentTransType;
        private TransactionType? SearchType = null;
        public BankApplication()
        {
            _bank = new Bank();
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
                _bank.AddNewClient(tbName.Text, tbSurname.Text, age, tbPhone.Text, tbMail.Text, cur, chkbEnabled.Checked, member, blnc);
                _bank.SaveClients();
                pnlRegistration.Visible = false;
                pnlAccountProp.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataGridSearchUpdate();
        }

        private void PanelsVisibility(bool visible)
        {
            pnlEdit.Visible = visible;
            pnlTransaction.Visible = visible;
            pnlAccountProp.Visible = visible;
            pnlRegistration.Visible = visible;
            pnlClientsSearch.Visible = visible;
            pnlTransSearch.Visible = visible;
        }

        private void btnAccountProp_Click(object sender, EventArgs e)
        {
            pnlAccountProp.Visible = !pnlAccountProp.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRegistration.Visible = false;
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsVisibility(false);
            pnlRegistration.Visible = true;
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
            dataGridClients.Rows.Clear();
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

        private void FillTransactionsGrid(DateTime from, DateTime to, string acc, string id)
        {
            dataGridTrans.Rows.Clear();
            List<Transaction> transactions = _bank.SearcTransactions(from.Date, to.Date, acc, id, SearchType);
            
            for (int i = 0; i < transactions.Count; i++)
            {
                var temp = transactions[i] as TransferTran;
                dataGridTrans.Rows.Add();
                dataGridTrans.Rows[i].Cells[0].Value = transactions[i]._time;
                dataGridTrans.Rows[i].Cells[1].Value = transactions[i]._userId;
                dataGridTrans.Rows[i].Cells[2].Value = transactions[i].account;
                dataGridTrans.Rows[i].Cells[3].Value = transactions[i]._type;
                dataGridTrans.Rows[i].Cells[4].Value = temp != null ? temp._transferTo : "";
                dataGridTrans.Rows[i].Cells[5].Value = transactions[i]._amount;
                dataGridTrans.Rows[i].Cells[6].Value = transactions[i]._currency;
                dataGridTrans.Rows[i].Cells[7].Value = transactions[i]._charge;
                dataGridTrans.Rows[i].Cells[8].Value = transactions[i]._totalAmount;
                dataGridTrans.Rows[i].Cells[9].Value = transactions[i]._totalCur;
            }
        }

        private void DataGridSearchUpdate()
        {
            dataGridClients.Rows.Clear();
            List<BaseClient> clients = _bank.SearchClients(tbSearchID.Text, tbSearchAcc.Text, tbSearchName.Text, tbSearchSurname.Text, tbSearchBalance.Text);
            string membership;
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i] is PlatinumClient) membership = "Platinum";
                else if (clients[i] is GoldenClient) membership = "Gold";
                else membership = "Normal";
                dataGridClients.Rows.Add();
                dataGridClients.Rows[i].Cells[0].Value = clients[i].UserID;
                dataGridClients.Rows[i].Cells[1].Value = clients[i].Account;
                dataGridClients.Rows[i].Cells[2].Value = clients[i].Name;
                dataGridClients.Rows[i].Cells[3].Value = clients[i].Surname;
                dataGridClients.Rows[i].Cells[4].Value = clients[i].Phone;
                dataGridClients.Rows[i].Cells[5].Value = clients[i].Mail;
                dataGridClients.Rows[i].Cells[6].Value = clients[i].Balance.ToString("F");
                dataGridClients.Rows[i].Cells[7].Value = clients[i].Currency;
                dataGridClients.Rows[i].Cells[8].Value = membership;
                dataGridClients.Rows[i].Cells[9].Value = clients[i].Enabled;
            }
        }

        private void btnTransSearch_Click(object sender, EventArgs e)
        {
            dataGridTrans.Rows.Clear();
            FillTransactionsGrid(dtpTimeFrom.Value.Date, dtpTimeTo.Value.Date, tbTransSearchAcc.Text, tbTransSearchID.Text);
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
                        _bank.Withdraw(tbTransFromAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                    case TransactionType.Deposit:
                        _bank.Deposit(tbTransFromAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                    case TransactionType.Transfer:
                        _bank.Transfer(tbTransFromAcc.Text, tbTransToAcc.Text, Convert.ToDecimal(tbTransAmount.Text), EnumConverter.StringToCurrency(cbTransCur.Text));
                        break;
                    default:
                        throw new ArgumentException("Unknown error!");
                }
                MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentTransType = null;
                pnlTransaction.Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
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
            SearchType = null;
            PanelsVisibility(false);
            pnlTransSearch.Visible = true;
        }

        private void FillEditForm()
        {
            if (dataGridClients.SelectedCells.Count > 0)
            {
                BaseClient client = null;
                try
                {
                    client = _bank.FindClient(dataGridClients.Rows[dataGridClients.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                }
                catch (Exception ex )
                {

                    throw ex;
                }
                pnlEdit.Visible = true;
                tbEditViewID.Text = client.UserID.ToString();
                tbEditAge.Text = client.Age.ToString();
                tbEditName.Text = client.Name;
                tbEditSurname.Text = client.Surname;
                tbEditMail.Text = client.Mail;
                tbEditPhone.Text = client.Phone;
                cbEditEnabled.Checked = client.Enabled; 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FillEditForm();

        }

        private void pnlEdit_VisibleChanged(object sender, EventArgs e)
        {
            tbEditName.Clear();
            tbEditSurname.Clear();
            tbEditMail.Clear();
            tbEditPhone.Clear();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                _bank.EditClient(Convert.ToInt64(tbEditViewID.Text), tbEditName.Text, tbEditSurname.Text, tbEditMail.Text, tbEditPhone.Text, Convert.ToInt32(tbEditAge.Text), cbEditEnabled.Checked);
                MessageBox.Show("Client Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlEdit.Visible = false;
                DataGridSearchUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BankApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            _bank.SaveClients();
            _bank.SaveTransactions();
        }

        private void withdrawTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchType = TransactionType.Withdraw;
            dataGridTrans.Rows.Clear();
            FillTransactionsGrid(dtpTimeFrom.Value.Date, dtpTimeTo.Value.Date, tbTransSearchAcc.Text, tbTransSearchID.Text);
        }

        private void depositTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchType = TransactionType.Deposit;
            dataGridTrans.Rows.Clear();
            FillTransactionsGrid(dtpTimeFrom.Value.Date, dtpTimeTo.Value.Date, tbTransSearchAcc.Text, tbTransSearchID.Text);
        }

        private void transferTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchType = TransactionType.Transfer;
            dataGridTrans.Rows.Clear();
            FillTransactionsGrid(dtpTimeFrom.Value.Date, dtpTimeTo.Value.Date, tbTransSearchAcc.Text, tbTransSearchID.Text);
        }

        private void btnTransSearchExportToCsv_Click(object sender, EventArgs e)
        {
           

            if (dataGridTrans.SelectedRows.Count > 0)
            {
                svdExportToCSV.ShowDialog();
                if (svdExportToCSV.FileName != string.Empty)
                {
                    string filepath = svdExportToCSV.FileName;
                    try
                    {
                        if (File.Exists(filepath)) File.Delete(filepath);
                        foreach (DataGridViewColumn item in dataGridTrans.Columns)
                        {
                            File.AppendAllText(filepath, item.HeaderText + ';');
                        }

                        File.AppendAllText(filepath, Environment.NewLine);
                        for (int i = 0; i < dataGridTrans.SelectedRows.Count; i++)
                        {
                            for (int j = 0; j < dataGridTrans.SelectedRows[i].Cells.Count; j++)
                            {
                                File.AppendAllText(filepath, dataGridTrans.SelectedRows[i].Cells[j].Value.ToString() + ';');
                            }
                            File.AppendAllText(filepath, Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
