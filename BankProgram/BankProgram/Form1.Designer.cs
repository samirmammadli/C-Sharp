﻿using System.Runtime.InteropServices;

namespace BankProgram
{
    partial class BankApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTransacionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMembership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnAccountProp = new System.Windows.Forms.Button();
            this.chkbEnabled = new System.Windows.Forms.CheckBox();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.lbMember = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlAccountProp = new System.Windows.Forms.Panel();
            this.tbSetBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.tbEditAccount = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.tbEditID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.pnlClientsSearch = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbSearchBalance = new System.Windows.Forms.Label();
            this.lbSearchSurname = new System.Windows.Forms.Label();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.lbSearchAcc = new System.Windows.Forms.Label();
            this.lbSearchID = new System.Windows.Forms.Label();
            this.tbSearchBalance = new System.Windows.Forms.TextBox();
            this.tbSearchSurname = new System.Windows.Forms.TextBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.tbSearchAcc = new System.Windows.Forms.TextBox();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.pnlTransSearch = new System.Windows.Forms.Panel();
            this.btnTransSearchExportToCsv = new System.Windows.Forms.Button();
            this.lbTransSearchTo = new System.Windows.Forms.Label();
            this.lbTransSearchFrom = new System.Windows.Forms.Label();
            this.lbTransSearchAcc = new System.Windows.Forms.Label();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lbTransSearchID = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.tbTransSearchAcc = new System.Windows.Forms.TextBox();
            this.btnTransSearch = new System.Windows.Forms.Button();
            this.tbTransSearchID = new System.Windows.Forms.TextBox();
            this.dataGridTrans = new System.Windows.Forms.DataGridView();
            this.dgvTransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransTransTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransTotalCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.btnTransCancel = new System.Windows.Forms.Button();
            this.btnTransSend = new System.Windows.Forms.Button();
            this.tbTransAmount = new System.Windows.Forms.TextBox();
            this.lbTransAmount = new System.Windows.Forms.Label();
            this.tbTransToAcc = new System.Windows.Forms.TextBox();
            this.lbTransToAcc = new System.Windows.Forms.Label();
            this.tbTransFromAcc = new System.Windows.Forms.TextBox();
            this.cbTransCur = new System.Windows.Forms.ComboBox();
            this.lbTransFromAcc = new System.Windows.Forms.Label();
            this.lbTransCur = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cbEditEnabled = new System.Windows.Forms.CheckBox();
            this.lbEditID = new System.Windows.Forms.Label();
            this.tbEditViewID = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.lbEditName = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.tbEditPhone = new System.Windows.Forms.TextBox();
            this.lbEditSurname = new System.Windows.Forms.Label();
            this.lbEditPhone = new System.Windows.Forms.Label();
            this.tbEditSurname = new System.Windows.Forms.TextBox();
            this.tbEditMail = new System.Windows.Forms.TextBox();
            this.lbEditAge = new System.Windows.Forms.Label();
            this.lbEditMail = new System.Windows.Forms.Label();
            this.tbEditAge = new System.Windows.Forms.TextBox();
            this.svdExportToCSV = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.pnlRegistration.SuspendLayout();
            this.pnlAccountProp.SuspendLayout();
            this.pnlClientsSearch.SuspendLayout();
            this.pnlTransSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrans)).BeginInit();
            this.pnlTransaction.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.makeTransactionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.searchClientToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.toolsToolStripMenuItem.Text = "Clients";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addClientToolStripMenuItem.Text = "Add new client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.searchClientToolStripMenuItem.Text = "Search client";
            this.searchClientToolStripMenuItem.Click += new System.EventHandler(this.searchClientToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTransacionsToolStripMenuItem,
            this.withdrawTransactionsToolStripMenuItem,
            this.depositTransactionsToolStripMenuItem,
            this.transferTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.transactionsToolStripMenuItem.Text = "Search Transaction";
            // 
            // allTransacionsToolStripMenuItem
            // 
            this.allTransacionsToolStripMenuItem.Name = "allTransacionsToolStripMenuItem";
            this.allTransacionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.allTransacionsToolStripMenuItem.Text = "All transacions";
            this.allTransacionsToolStripMenuItem.Click += new System.EventHandler(this.allTransacionsToolStripMenuItem_Click);
            // 
            // withdrawTransactionsToolStripMenuItem
            // 
            this.withdrawTransactionsToolStripMenuItem.Name = "withdrawTransactionsToolStripMenuItem";
            this.withdrawTransactionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.withdrawTransactionsToolStripMenuItem.Text = "Withdraw";
            this.withdrawTransactionsToolStripMenuItem.Click += new System.EventHandler(this.withdrawTransactionsToolStripMenuItem_Click);
            // 
            // depositTransactionsToolStripMenuItem
            // 
            this.depositTransactionsToolStripMenuItem.Name = "depositTransactionsToolStripMenuItem";
            this.depositTransactionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.depositTransactionsToolStripMenuItem.Text = "Deposit";
            this.depositTransactionsToolStripMenuItem.Click += new System.EventHandler(this.depositTransactionsToolStripMenuItem_Click);
            // 
            // transferTransactionsToolStripMenuItem
            // 
            this.transferTransactionsToolStripMenuItem.Name = "transferTransactionsToolStripMenuItem";
            this.transferTransactionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.transferTransactionsToolStripMenuItem.Text = "Transfer";
            this.transferTransactionsToolStripMenuItem.Click += new System.EventHandler(this.transferTransactionsToolStripMenuItem_Click);
            // 
            // makeTransactionToolStripMenuItem
            // 
            this.makeTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.makeTransactionToolStripMenuItem.Name = "makeTransactionToolStripMenuItem";
            this.makeTransactionToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.makeTransactionToolStripMenuItem.Text = "Make Transaction";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgAccount,
            this.dgName,
            this.dgSurname,
            this.dgPhone,
            this.dgMail,
            this.dgBalance,
            this.dgCurrency,
            this.dgMembership,
            this.dgEnabled});
            this.dataGridClients.Location = new System.Drawing.Point(6, 55);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.Size = new System.Drawing.Size(1046, 307);
            this.dataGridClients.TabIndex = 3;
            // 
            // dgID
            // 
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            this.dgID.Width = 50;
            // 
            // dgAccount
            // 
            this.dgAccount.HeaderText = "Account";
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.ReadOnly = true;
            this.dgAccount.Width = 130;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgSurname
            // 
            this.dgSurname.HeaderText = "Surname";
            this.dgSurname.Name = "dgSurname";
            this.dgSurname.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.HeaderText = "Phone";
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // dgMail
            // 
            this.dgMail.HeaderText = "Mail";
            this.dgMail.Name = "dgMail";
            this.dgMail.ReadOnly = true;
            this.dgMail.Width = 130;
            // 
            // dgBalance
            // 
            this.dgBalance.HeaderText = "Balance";
            this.dgBalance.Name = "dgBalance";
            this.dgBalance.ReadOnly = true;
            // 
            // dgCurrency
            // 
            this.dgCurrency.HeaderText = "Currency";
            this.dgCurrency.Name = "dgCurrency";
            this.dgCurrency.ReadOnly = true;
            // 
            // dgMembership
            // 
            this.dgMembership.HeaderText = "Membership";
            this.dgMembership.Name = "dgMembership";
            this.dgMembership.ReadOnly = true;
            // 
            // dgEnabled
            // 
            this.dgEnabled.HeaderText = "Enabled";
            this.dgEnabled.Name = "dgEnabled";
            this.dgEnabled.ReadOnly = true;
            this.dgEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Controls.Add(this.btnAccountProp);
            this.pnlRegistration.Controls.Add(this.chkbEnabled);
            this.pnlRegistration.Controls.Add(this.cbMember);
            this.pnlRegistration.Controls.Add(this.lbMember);
            this.pnlRegistration.Controls.Add(this.cbCurrency);
            this.pnlRegistration.Controls.Add(this.lbCurrency);
            this.pnlRegistration.Controls.Add(this.btnCancel);
            this.pnlRegistration.Controls.Add(this.btnAdd);
            this.pnlRegistration.Controls.Add(this.tbPhone);
            this.pnlRegistration.Controls.Add(this.lbPhone);
            this.pnlRegistration.Controls.Add(this.tbMail);
            this.pnlRegistration.Controls.Add(this.lbMail);
            this.pnlRegistration.Controls.Add(this.tbAge);
            this.pnlRegistration.Controls.Add(this.lbAge);
            this.pnlRegistration.Controls.Add(this.tbSurname);
            this.pnlRegistration.Controls.Add(this.lbSurname);
            this.pnlRegistration.Controls.Add(this.tbName);
            this.pnlRegistration.Controls.Add(this.lbName);
            this.pnlRegistration.Location = new System.Drawing.Point(12, 26);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(349, 309);
            this.pnlRegistration.TabIndex = 5;
            this.pnlRegistration.Visible = false;
            this.pnlRegistration.VisibleChanged += new System.EventHandler(this.pnlRegEdit_VisibleChanged);
            // 
            // btnAccountProp
            // 
            this.btnAccountProp.Location = new System.Drawing.Point(206, 272);
            this.btnAccountProp.Name = "btnAccountProp";
            this.btnAccountProp.Size = new System.Drawing.Size(113, 23);
            this.btnAccountProp.TabIndex = 18;
            this.btnAccountProp.Text = "Account Properties";
            this.btnAccountProp.UseVisualStyleBackColor = true;
            this.btnAccountProp.Click += new System.EventHandler(this.btnAccountProp_Click);
            // 
            // chkbEnabled
            // 
            this.chkbEnabled.AutoSize = true;
            this.chkbEnabled.Checked = true;
            this.chkbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbEnabled.Location = new System.Drawing.Point(6, 228);
            this.chkbEnabled.Name = "chkbEnabled";
            this.chkbEnabled.Size = new System.Drawing.Size(78, 20);
            this.chkbEnabled.TabIndex = 17;
            this.chkbEnabled.Text = "Enabled";
            this.chkbEnabled.UseVisualStyleBackColor = true;
            // 
            // cbMember
            // 
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Items.AddRange(new object[] {
            "Normal",
            "Gold",
            "Platinum"});
            this.cbMember.Location = new System.Drawing.Point(76, 166);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(121, 21);
            this.cbMember.TabIndex = 15;
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMember.Location = new System.Drawing.Point(3, 167);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(61, 16);
            this.lbMember.TabIndex = 14;
            this.lbMember.Text = "Member:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "AZN",
            "USD",
            "EUR"});
            this.cbCurrency.Location = new System.Drawing.Point(76, 201);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbCurrency.TabIndex = 13;
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrency.Location = new System.Drawing.Point(3, 202);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(64, 16);
            this.lbCurrency.TabIndex = 12;
            this.lbCurrency.Text = "Currency:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(76, 137);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(243, 22);
            this.tbPhone.TabIndex = 9;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(3, 137);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(50, 16);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "Phone:";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMail.Location = new System.Drawing.Point(76, 109);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(243, 22);
            this.tbMail.TabIndex = 7;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMail.Location = new System.Drawing.Point(3, 109);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 16);
            this.lbMail.TabIndex = 6;
            this.lbMail.Text = "Mail:";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAge.Location = new System.Drawing.Point(76, 81);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(38, 22);
            this.tbAge.TabIndex = 5;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.Location = new System.Drawing.Point(3, 81);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(36, 16);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Age:";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(76, 53);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(243, 22);
            this.tbSurname.TabIndex = 3;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(3, 53);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(58, 16);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Surame:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(76, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 22);
            this.tbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(3, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 368);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlAccountProp
            // 
            this.pnlAccountProp.Controls.Add(this.tbSetBalance);
            this.pnlAccountProp.Controls.Add(this.lbBalance);
            this.pnlAccountProp.Controls.Add(this.tbEditAccount);
            this.pnlAccountProp.Controls.Add(this.lbAccount);
            this.pnlAccountProp.Controls.Add(this.tbEditID);
            this.pnlAccountProp.Controls.Add(this.lbID);
            this.pnlAccountProp.Location = new System.Drawing.Point(364, 26);
            this.pnlAccountProp.Name = "pnlAccountProp";
            this.pnlAccountProp.Size = new System.Drawing.Size(336, 125);
            this.pnlAccountProp.TabIndex = 7;
            this.pnlAccountProp.Visible = false;
            // 
            // tbSetBalance
            // 
            this.tbSetBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetBalance.Location = new System.Drawing.Point(76, 81);
            this.tbSetBalance.Name = "tbSetBalance";
            this.tbSetBalance.Size = new System.Drawing.Size(243, 22);
            this.tbSetBalance.TabIndex = 24;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBalance.Location = new System.Drawing.Point(3, 81);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(61, 16);
            this.lbBalance.TabIndex = 23;
            this.lbBalance.Text = "Balance:";
            // 
            // tbEditAccount
            // 
            this.tbEditAccount.Enabled = false;
            this.tbEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditAccount.Location = new System.Drawing.Point(76, 53);
            this.tbEditAccount.Name = "tbEditAccount";
            this.tbEditAccount.Size = new System.Drawing.Size(243, 22);
            this.tbEditAccount.TabIndex = 22;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccount.Location = new System.Drawing.Point(3, 53);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(59, 16);
            this.lbAccount.TabIndex = 21;
            this.lbAccount.Text = "Account:";
            // 
            // tbEditID
            // 
            this.tbEditID.Enabled = false;
            this.tbEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditID.Location = new System.Drawing.Point(76, 25);
            this.tbEditID.Name = "tbEditID";
            this.tbEditID.Size = new System.Drawing.Size(243, 22);
            this.tbEditID.TabIndex = 20;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbID.Location = new System.Drawing.Point(3, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 16);
            this.lbID.TabIndex = 19;
            this.lbID.Text = "ID:";
            // 
            // pnlClientsSearch
            // 
            this.pnlClientsSearch.Controls.Add(this.btnEdit);
            this.pnlClientsSearch.Controls.Add(this.lbSearchBalance);
            this.pnlClientsSearch.Controls.Add(this.lbSearchSurname);
            this.pnlClientsSearch.Controls.Add(this.lbSearchName);
            this.pnlClientsSearch.Controls.Add(this.lbSearchAcc);
            this.pnlClientsSearch.Controls.Add(this.lbSearchID);
            this.pnlClientsSearch.Controls.Add(this.tbSearchBalance);
            this.pnlClientsSearch.Controls.Add(this.tbSearchSurname);
            this.pnlClientsSearch.Controls.Add(this.tbSearchName);
            this.pnlClientsSearch.Controls.Add(this.tbSearchAcc);
            this.pnlClientsSearch.Controls.Add(this.tbSearchID);
            this.pnlClientsSearch.Controls.Add(this.dataGridClients);
            this.pnlClientsSearch.Controls.Add(this.btnSearch);
            this.pnlClientsSearch.Location = new System.Drawing.Point(9, 26);
            this.pnlClientsSearch.Name = "pnlClientsSearch";
            this.pnlClientsSearch.Size = new System.Drawing.Size(1055, 399);
            this.pnlClientsSearch.TabIndex = 8;
            this.pnlClientsSearch.Visible = false;
            this.pnlClientsSearch.VisibleChanged += new System.EventHandler(this.pnlSearch_VisibleChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(111, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 23);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbSearchBalance
            // 
            this.lbSearchBalance.AutoSize = true;
            this.lbSearchBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchBalance.Location = new System.Drawing.Point(613, 8);
            this.lbSearchBalance.Name = "lbSearchBalance";
            this.lbSearchBalance.Size = new System.Drawing.Size(61, 16);
            this.lbSearchBalance.TabIndex = 29;
            this.lbSearchBalance.Text = "Balance:";
            // 
            // lbSearchSurname
            // 
            this.lbSearchSurname.AutoSize = true;
            this.lbSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchSurname.Location = new System.Drawing.Point(445, 8);
            this.lbSearchSurname.Name = "lbSearchSurname";
            this.lbSearchSurname.Size = new System.Drawing.Size(65, 16);
            this.lbSearchSurname.TabIndex = 28;
            this.lbSearchSurname.Text = "Surname:";
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchName.Location = new System.Drawing.Point(286, 8);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(48, 16);
            this.lbSearchName.TabIndex = 27;
            this.lbSearchName.Text = "Name:";
            // 
            // lbSearchAcc
            // 
            this.lbSearchAcc.AutoSize = true;
            this.lbSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchAcc.Location = new System.Drawing.Point(143, 8);
            this.lbSearchAcc.Name = "lbSearchAcc";
            this.lbSearchAcc.Size = new System.Drawing.Size(59, 16);
            this.lbSearchAcc.TabIndex = 26;
            this.lbSearchAcc.Text = "Account:";
            // 
            // lbSearchID
            // 
            this.lbSearchID.AutoSize = true;
            this.lbSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchID.Location = new System.Drawing.Point(5, 8);
            this.lbSearchID.Name = "lbSearchID";
            this.lbSearchID.Size = new System.Drawing.Size(24, 16);
            this.lbSearchID.TabIndex = 19;
            this.lbSearchID.Text = "ID:";
            // 
            // tbSearchBalance
            // 
            this.tbSearchBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchBalance.Location = new System.Drawing.Point(616, 27);
            this.tbSearchBalance.Name = "tbSearchBalance";
            this.tbSearchBalance.Size = new System.Drawing.Size(143, 22);
            this.tbSearchBalance.TabIndex = 24;
            // 
            // tbSearchSurname
            // 
            this.tbSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchSurname.Location = new System.Drawing.Point(448, 27);
            this.tbSearchSurname.Name = "tbSearchSurname";
            this.tbSearchSurname.Size = new System.Drawing.Size(162, 22);
            this.tbSearchSurname.TabIndex = 22;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchName.Location = new System.Drawing.Point(289, 27);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(149, 22);
            this.tbSearchName.TabIndex = 21;
            // 
            // tbSearchAcc
            // 
            this.tbSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchAcc.Location = new System.Drawing.Point(146, 27);
            this.tbSearchAcc.Name = "tbSearchAcc";
            this.tbSearchAcc.Size = new System.Drawing.Size(137, 22);
            this.tbSearchAcc.TabIndex = 20;
            // 
            // tbSearchID
            // 
            this.tbSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchID.Location = new System.Drawing.Point(6, 27);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(134, 22);
            this.tbSearchID.TabIndex = 19;
            // 
            // pnlTransSearch
            // 
            this.pnlTransSearch.Controls.Add(this.btnTransSearchExportToCsv);
            this.pnlTransSearch.Controls.Add(this.lbTransSearchTo);
            this.pnlTransSearch.Controls.Add(this.lbTransSearchFrom);
            this.pnlTransSearch.Controls.Add(this.lbTransSearchAcc);
            this.pnlTransSearch.Controls.Add(this.dtpTimeTo);
            this.pnlTransSearch.Controls.Add(this.lbTransSearchID);
            this.pnlTransSearch.Controls.Add(this.dtpTimeFrom);
            this.pnlTransSearch.Controls.Add(this.tbTransSearchAcc);
            this.pnlTransSearch.Controls.Add(this.btnTransSearch);
            this.pnlTransSearch.Controls.Add(this.tbTransSearchID);
            this.pnlTransSearch.Controls.Add(this.dataGridTrans);
            this.pnlTransSearch.Location = new System.Drawing.Point(9, 27);
            this.pnlTransSearch.Name = "pnlTransSearch";
            this.pnlTransSearch.Size = new System.Drawing.Size(1055, 384);
            this.pnlTransSearch.TabIndex = 9;
            this.pnlTransSearch.Visible = false;
            // 
            // btnTransSearchExportToCsv
            // 
            this.btnTransSearchExportToCsv.Location = new System.Drawing.Point(110, 352);
            this.btnTransSearchExportToCsv.Name = "btnTransSearchExportToCsv";
            this.btnTransSearchExportToCsv.Size = new System.Drawing.Size(99, 23);
            this.btnTransSearchExportToCsv.TabIndex = 36;
            this.btnTransSearchExportToCsv.Text = "Export selected to csv";
            this.btnTransSearchExportToCsv.UseVisualStyleBackColor = true;
            this.btnTransSearchExportToCsv.Click += new System.EventHandler(this.btnTransSearchExportToCsv_Click);
            // 
            // lbTransSearchTo
            // 
            this.lbTransSearchTo.AutoSize = true;
            this.lbTransSearchTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransSearchTo.Location = new System.Drawing.Point(403, 1);
            this.lbTransSearchTo.Name = "lbTransSearchTo";
            this.lbTransSearchTo.Size = new System.Drawing.Size(28, 16);
            this.lbTransSearchTo.TabIndex = 35;
            this.lbTransSearchTo.Text = "To:";
            // 
            // lbTransSearchFrom
            // 
            this.lbTransSearchFrom.AutoSize = true;
            this.lbTransSearchFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransSearchFrom.Location = new System.Drawing.Point(292, 1);
            this.lbTransSearchFrom.Name = "lbTransSearchFrom";
            this.lbTransSearchFrom.Size = new System.Drawing.Size(42, 16);
            this.lbTransSearchFrom.TabIndex = 34;
            this.lbTransSearchFrom.Text = "From:";
            // 
            // lbTransSearchAcc
            // 
            this.lbTransSearchAcc.AutoSize = true;
            this.lbTransSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransSearchAcc.Location = new System.Drawing.Point(149, -1);
            this.lbTransSearchAcc.Name = "lbTransSearchAcc";
            this.lbTransSearchAcc.Size = new System.Drawing.Size(59, 16);
            this.lbTransSearchAcc.TabIndex = 33;
            this.lbTransSearchAcc.Text = "Account:";
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Location = new System.Drawing.Point(406, 20);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(107, 20);
            this.dtpTimeTo.TabIndex = 32;
            // 
            // lbTransSearchID
            // 
            this.lbTransSearchID.AutoSize = true;
            this.lbTransSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransSearchID.Location = new System.Drawing.Point(6, -1);
            this.lbTransSearchID.Name = "lbTransSearchID";
            this.lbTransSearchID.Size = new System.Drawing.Size(24, 16);
            this.lbTransSearchID.TabIndex = 30;
            this.lbTransSearchID.Text = "ID:";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Location = new System.Drawing.Point(292, 20);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(108, 20);
            this.dtpTimeFrom.TabIndex = 31;
            // 
            // tbTransSearchAcc
            // 
            this.tbTransSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTransSearchAcc.Location = new System.Drawing.Point(149, 18);
            this.tbTransSearchAcc.Name = "tbTransSearchAcc";
            this.tbTransSearchAcc.Size = new System.Drawing.Size(137, 22);
            this.tbTransSearchAcc.TabIndex = 32;
            // 
            // btnTransSearch
            // 
            this.btnTransSearch.Location = new System.Drawing.Point(9, 352);
            this.btnTransSearch.Name = "btnTransSearch";
            this.btnTransSearch.Size = new System.Drawing.Size(99, 23);
            this.btnTransSearch.TabIndex = 30;
            this.btnTransSearch.Text = "Search";
            this.btnTransSearch.UseVisualStyleBackColor = true;
            this.btnTransSearch.Click += new System.EventHandler(this.btnTransSearch_Click);
            // 
            // tbTransSearchID
            // 
            this.tbTransSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTransSearchID.Location = new System.Drawing.Point(9, 18);
            this.tbTransSearchID.Name = "tbTransSearchID";
            this.tbTransSearchID.Size = new System.Drawing.Size(134, 22);
            this.tbTransSearchID.TabIndex = 31;
            // 
            // dataGridTrans
            // 
            this.dataGridTrans.AllowUserToAddRows = false;
            this.dataGridTrans.AllowUserToDeleteRows = false;
            this.dataGridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTransDate,
            this.dgvTransId,
            this.dgvTransAccount,
            this.dgvTransType,
            this.dgvTransTransTo,
            this.dgvTransAmount,
            this.dgvTransCurrency,
            this.dgvTransCharge,
            this.dgvTransTotalAmount,
            this.dgvTransTotalCurrency});
            this.dataGridTrans.Location = new System.Drawing.Point(9, 62);
            this.dataGridTrans.Name = "dataGridTrans";
            this.dataGridTrans.ReadOnly = true;
            this.dataGridTrans.Size = new System.Drawing.Size(1046, 284);
            this.dataGridTrans.TabIndex = 0;
            // 
            // dgvTransDate
            // 
            this.dgvTransDate.HeaderText = "Date";
            this.dgvTransDate.Name = "dgvTransDate";
            this.dgvTransDate.ReadOnly = true;
            // 
            // dgvTransId
            // 
            this.dgvTransId.HeaderText = "ID";
            this.dgvTransId.Name = "dgvTransId";
            this.dgvTransId.ReadOnly = true;
            // 
            // dgvTransAccount
            // 
            this.dgvTransAccount.HeaderText = "Account";
            this.dgvTransAccount.Name = "dgvTransAccount";
            this.dgvTransAccount.ReadOnly = true;
            // 
            // dgvTransType
            // 
            this.dgvTransType.HeaderText = "Type";
            this.dgvTransType.Name = "dgvTransType";
            this.dgvTransType.ReadOnly = true;
            // 
            // dgvTransTransTo
            // 
            this.dgvTransTransTo.HeaderText = "To account";
            this.dgvTransTransTo.Name = "dgvTransTransTo";
            this.dgvTransTransTo.ReadOnly = true;
            // 
            // dgvTransAmount
            // 
            this.dgvTransAmount.HeaderText = "Amount";
            this.dgvTransAmount.Name = "dgvTransAmount";
            this.dgvTransAmount.ReadOnly = true;
            // 
            // dgvTransCurrency
            // 
            this.dgvTransCurrency.HeaderText = "Currency";
            this.dgvTransCurrency.Name = "dgvTransCurrency";
            this.dgvTransCurrency.ReadOnly = true;
            // 
            // dgvTransCharge
            // 
            this.dgvTransCharge.HeaderText = "Charge";
            this.dgvTransCharge.Name = "dgvTransCharge";
            this.dgvTransCharge.ReadOnly = true;
            // 
            // dgvTransTotalAmount
            // 
            this.dgvTransTotalAmount.HeaderText = "Total";
            this.dgvTransTotalAmount.Name = "dgvTransTotalAmount";
            this.dgvTransTotalAmount.ReadOnly = true;
            // 
            // dgvTransTotalCurrency
            // 
            this.dgvTransTotalCurrency.HeaderText = "Currency";
            this.dgvTransTotalCurrency.Name = "dgvTransTotalCurrency";
            this.dgvTransTotalCurrency.ReadOnly = true;
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.btnTransCancel);
            this.pnlTransaction.Controls.Add(this.btnTransSend);
            this.pnlTransaction.Controls.Add(this.tbTransAmount);
            this.pnlTransaction.Controls.Add(this.lbTransAmount);
            this.pnlTransaction.Controls.Add(this.tbTransToAcc);
            this.pnlTransaction.Controls.Add(this.lbTransToAcc);
            this.pnlTransaction.Controls.Add(this.tbTransFromAcc);
            this.pnlTransaction.Controls.Add(this.cbTransCur);
            this.pnlTransaction.Controls.Add(this.lbTransFromAcc);
            this.pnlTransaction.Controls.Add(this.lbTransCur);
            this.pnlTransaction.Location = new System.Drawing.Point(12, 30);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(336, 163);
            this.pnlTransaction.TabIndex = 10;
            this.pnlTransaction.Visible = false;
            this.pnlTransaction.VisibleChanged += new System.EventHandler(this.pnlTransaction_VisibleChanged);
            // 
            // btnTransCancel
            // 
            this.btnTransCancel.Location = new System.Drawing.Point(84, 137);
            this.btnTransCancel.Name = "btnTransCancel";
            this.btnTransCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTransCancel.TabIndex = 25;
            this.btnTransCancel.Text = "Cancel";
            this.btnTransCancel.UseVisualStyleBackColor = true;
            this.btnTransCancel.Click += new System.EventHandler(this.btnTransCancel_Click);
            // 
            // btnTransSend
            // 
            this.btnTransSend.Location = new System.Drawing.Point(3, 137);
            this.btnTransSend.Name = "btnTransSend";
            this.btnTransSend.Size = new System.Drawing.Size(75, 23);
            this.btnTransSend.TabIndex = 24;
            this.btnTransSend.Text = "Send";
            this.btnTransSend.UseVisualStyleBackColor = true;
            this.btnTransSend.Click += new System.EventHandler(this.btnTransSend_Click);
            // 
            // tbTransAmount
            // 
            this.tbTransAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTransAmount.Location = new System.Drawing.Point(94, 69);
            this.tbTransAmount.Name = "tbTransAmount";
            this.tbTransAmount.Size = new System.Drawing.Size(226, 22);
            this.tbTransAmount.TabIndex = 22;
            // 
            // lbTransAmount
            // 
            this.lbTransAmount.AutoSize = true;
            this.lbTransAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransAmount.Location = new System.Drawing.Point(4, 69);
            this.lbTransAmount.Name = "lbTransAmount";
            this.lbTransAmount.Size = new System.Drawing.Size(56, 16);
            this.lbTransAmount.TabIndex = 21;
            this.lbTransAmount.Text = "Amount:";
            // 
            // tbTransToAcc
            // 
            this.tbTransToAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTransToAcc.Location = new System.Drawing.Point(93, 36);
            this.tbTransToAcc.Name = "tbTransToAcc";
            this.tbTransToAcc.Size = new System.Drawing.Size(226, 22);
            this.tbTransToAcc.TabIndex = 21;
            // 
            // lbTransToAcc
            // 
            this.lbTransToAcc.AutoSize = true;
            this.lbTransToAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransToAcc.Location = new System.Drawing.Point(3, 36);
            this.lbTransToAcc.Name = "lbTransToAcc";
            this.lbTransToAcc.Size = new System.Drawing.Size(78, 16);
            this.lbTransToAcc.TabIndex = 19;
            this.lbTransToAcc.Text = "To account:";
            // 
            // tbTransFromAcc
            // 
            this.tbTransFromAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTransFromAcc.Location = new System.Drawing.Point(93, 8);
            this.tbTransFromAcc.Name = "tbTransFromAcc";
            this.tbTransFromAcc.Size = new System.Drawing.Size(226, 22);
            this.tbTransFromAcc.TabIndex = 20;
            // 
            // cbTransCur
            // 
            this.cbTransCur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransCur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTransCur.FormattingEnabled = true;
            this.cbTransCur.Items.AddRange(new object[] {
            "AZN",
            "USD",
            "EUR"});
            this.cbTransCur.Location = new System.Drawing.Point(94, 100);
            this.cbTransCur.Name = "cbTransCur";
            this.cbTransCur.Size = new System.Drawing.Size(121, 21);
            this.cbTransCur.TabIndex = 23;
            // 
            // lbTransFromAcc
            // 
            this.lbTransFromAcc.AutoSize = true;
            this.lbTransFromAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransFromAcc.Location = new System.Drawing.Point(3, 8);
            this.lbTransFromAcc.Name = "lbTransFromAcc";
            this.lbTransFromAcc.Size = new System.Drawing.Size(59, 16);
            this.lbTransFromAcc.TabIndex = 19;
            this.lbTransFromAcc.Text = "Account:";
            // 
            // lbTransCur
            // 
            this.lbTransCur.AutoSize = true;
            this.lbTransCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransCur.Location = new System.Drawing.Point(4, 100);
            this.lbTransCur.Name = "lbTransCur";
            this.lbTransCur.Size = new System.Drawing.Size(64, 16);
            this.lbTransCur.TabIndex = 14;
            this.lbTransCur.Text = "Currency:";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.cbEditEnabled);
            this.pnlEdit.Controls.Add(this.lbEditID);
            this.pnlEdit.Controls.Add(this.tbEditViewID);
            this.pnlEdit.Controls.Add(this.btnEditCancel);
            this.pnlEdit.Controls.Add(this.btnEditSave);
            this.pnlEdit.Controls.Add(this.lbEditName);
            this.pnlEdit.Controls.Add(this.tbEditName);
            this.pnlEdit.Controls.Add(this.tbEditPhone);
            this.pnlEdit.Controls.Add(this.lbEditSurname);
            this.pnlEdit.Controls.Add(this.lbEditPhone);
            this.pnlEdit.Controls.Add(this.tbEditSurname);
            this.pnlEdit.Controls.Add(this.tbEditMail);
            this.pnlEdit.Controls.Add(this.lbEditAge);
            this.pnlEdit.Controls.Add(this.lbEditMail);
            this.pnlEdit.Controls.Add(this.tbEditAge);
            this.pnlEdit.Location = new System.Drawing.Point(9, 423);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(336, 218);
            this.pnlEdit.TabIndex = 31;
            this.pnlEdit.Visible = false;
            this.pnlEdit.VisibleChanged += new System.EventHandler(this.pnlEdit_VisibleChanged);
            // 
            // cbEditEnabled
            // 
            this.cbEditEnabled.AutoSize = true;
            this.cbEditEnabled.Checked = true;
            this.cbEditEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEditEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEditEnabled.Location = new System.Drawing.Point(183, 181);
            this.cbEditEnabled.Name = "cbEditEnabled";
            this.cbEditEnabled.Size = new System.Drawing.Size(78, 20);
            this.cbEditEnabled.TabIndex = 19;
            this.cbEditEnabled.Text = "Enabled";
            this.cbEditEnabled.UseVisualStyleBackColor = true;
            // 
            // lbEditID
            // 
            this.lbEditID.AutoSize = true;
            this.lbEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditID.Location = new System.Drawing.Point(4, 9);
            this.lbEditID.Name = "lbEditID";
            this.lbEditID.Size = new System.Drawing.Size(24, 16);
            this.lbEditID.TabIndex = 33;
            this.lbEditID.Text = "ID:";
            // 
            // tbEditViewID
            // 
            this.tbEditViewID.Enabled = false;
            this.tbEditViewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditViewID.Location = new System.Drawing.Point(77, 9);
            this.tbEditViewID.Name = "tbEditViewID";
            this.tbEditViewID.Size = new System.Drawing.Size(243, 22);
            this.tbEditViewID.TabIndex = 34;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(90, 182);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 32;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(7, 181);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditSave.TabIndex = 31;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // lbEditName
            // 
            this.lbEditName.AutoSize = true;
            this.lbEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditName.Location = new System.Drawing.Point(4, 33);
            this.lbEditName.Name = "lbEditName";
            this.lbEditName.Size = new System.Drawing.Size(48, 16);
            this.lbEditName.TabIndex = 19;
            this.lbEditName.Text = "Name:";
            // 
            // tbEditName
            // 
            this.tbEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditName.Location = new System.Drawing.Point(77, 33);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(243, 22);
            this.tbEditName.TabIndex = 20;
            // 
            // tbEditPhone
            // 
            this.tbEditPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditPhone.Location = new System.Drawing.Point(77, 145);
            this.tbEditPhone.Name = "tbEditPhone";
            this.tbEditPhone.Size = new System.Drawing.Size(243, 22);
            this.tbEditPhone.TabIndex = 28;
            // 
            // lbEditSurname
            // 
            this.lbEditSurname.AutoSize = true;
            this.lbEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditSurname.Location = new System.Drawing.Point(4, 61);
            this.lbEditSurname.Name = "lbEditSurname";
            this.lbEditSurname.Size = new System.Drawing.Size(58, 16);
            this.lbEditSurname.TabIndex = 21;
            this.lbEditSurname.Text = "Surame:";
            // 
            // lbEditPhone
            // 
            this.lbEditPhone.AutoSize = true;
            this.lbEditPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditPhone.Location = new System.Drawing.Point(4, 145);
            this.lbEditPhone.Name = "lbEditPhone";
            this.lbEditPhone.Size = new System.Drawing.Size(50, 16);
            this.lbEditPhone.TabIndex = 27;
            this.lbEditPhone.Text = "Phone:";
            // 
            // tbEditSurname
            // 
            this.tbEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditSurname.Location = new System.Drawing.Point(77, 61);
            this.tbEditSurname.Name = "tbEditSurname";
            this.tbEditSurname.Size = new System.Drawing.Size(243, 22);
            this.tbEditSurname.TabIndex = 22;
            // 
            // tbEditMail
            // 
            this.tbEditMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditMail.Location = new System.Drawing.Point(77, 117);
            this.tbEditMail.Name = "tbEditMail";
            this.tbEditMail.Size = new System.Drawing.Size(243, 22);
            this.tbEditMail.TabIndex = 26;
            // 
            // lbEditAge
            // 
            this.lbEditAge.AutoSize = true;
            this.lbEditAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditAge.Location = new System.Drawing.Point(4, 89);
            this.lbEditAge.Name = "lbEditAge";
            this.lbEditAge.Size = new System.Drawing.Size(36, 16);
            this.lbEditAge.TabIndex = 23;
            this.lbEditAge.Text = "Age:";
            // 
            // lbEditMail
            // 
            this.lbEditMail.AutoSize = true;
            this.lbEditMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditMail.Location = new System.Drawing.Point(4, 117);
            this.lbEditMail.Name = "lbEditMail";
            this.lbEditMail.Size = new System.Drawing.Size(36, 16);
            this.lbEditMail.TabIndex = 25;
            this.lbEditMail.Text = "Mail:";
            // 
            // tbEditAge
            // 
            this.tbEditAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditAge.Location = new System.Drawing.Point(77, 89);
            this.tbEditAge.Name = "tbEditAge";
            this.tbEditAge.Size = new System.Drawing.Size(38, 22);
            this.tbEditAge.TabIndex = 24;
            // 
            // svdExportToCSV
            // 
            this.svdExportToCSV.DefaultExt = "csv";
            this.svdExportToCSV.FileName = "Transactions";
            this.svdExportToCSV.Title = "Save CSV File";
            // 
            // BankApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlTransSearch);
            this.Controls.Add(this.pnlAccountProp);
            this.Controls.Add(this.pnlClientsSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BankApplication";
            this.Text = "Bank Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankApplication_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.pnlAccountProp.ResumeLayout(false);
            this.pnlAccountProp.PerformLayout();
            this.pnlClientsSearch.ResumeLayout(false);
            this.pnlClientsSearch.PerformLayout();
            this.pnlTransSearch.ResumeLayout(false);
            this.pnlTransSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrans)).EndInit();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.CheckBox chkbEnabled;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTransacionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferTransactionsToolStripMenuItem;
        private System.Windows.Forms.Button btnAccountProp;
        private System.Windows.Forms.Panel pnlAccountProp;
        private System.Windows.Forms.TextBox tbSetBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox tbEditAccount;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox tbEditID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel pnlClientsSearch;
        private System.Windows.Forms.TextBox tbSearchBalance;
        private System.Windows.Forms.TextBox tbSearchSurname;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchAcc;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Label lbSearchBalance;
        private System.Windows.Forms.Label lbSearchSurname;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchAcc;
        private System.Windows.Forms.Label lbSearchID;
        private System.Windows.Forms.Panel pnlTransSearch;
        private System.Windows.Forms.DataGridView dataGridTrans;
        private System.Windows.Forms.Button btnTransSearch;
        private System.Windows.Forms.ToolStripMenuItem makeTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.TextBox tbTransAmount;
        private System.Windows.Forms.Label lbTransAmount;
        private System.Windows.Forms.TextBox tbTransToAcc;
        private System.Windows.Forms.Label lbTransToAcc;
        private System.Windows.Forms.TextBox tbTransFromAcc;
        private System.Windows.Forms.ComboBox cbTransCur;
        private System.Windows.Forms.Label lbTransFromAcc;
        private System.Windows.Forms.Label lbTransCur;
        private System.Windows.Forms.Button btnTransCancel;
        private System.Windows.Forms.Button btnTransSend;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransTransTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransTotalCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMembership;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgEnabled;
        private System.Windows.Forms.Label lbTransSearchAcc;
        private System.Windows.Forms.Label lbTransSearchID;
        private System.Windows.Forms.TextBox tbTransSearchAcc;
        private System.Windows.Forms.TextBox tbTransSearchID;
        private System.Windows.Forms.Label lbTransSearchTo;
        private System.Windows.Forms.Label lbTransSearchFrom;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Label lbEditName;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.TextBox tbEditPhone;
        private System.Windows.Forms.Label lbEditSurname;
        private System.Windows.Forms.Label lbEditPhone;
        private System.Windows.Forms.TextBox tbEditSurname;
        private System.Windows.Forms.TextBox tbEditMail;
        private System.Windows.Forms.Label lbEditAge;
        private System.Windows.Forms.Label lbEditMail;
        private System.Windows.Forms.TextBox tbEditAge;
        private System.Windows.Forms.Label lbEditID;
        private System.Windows.Forms.TextBox tbEditViewID;
        private System.Windows.Forms.CheckBox cbEditEnabled;
        private System.Windows.Forms.Button btnTransSearchExportToCsv;
        private System.Windows.Forms.SaveFileDialog svdExportToCSV;
    }
}

