using System.Runtime.InteropServices;

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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlRegEdit = new System.Windows.Forms.Panel();
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lbSearchEnabled = new System.Windows.Forms.Label();
            this.cbSearchEnabled = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlRegEdit.SuspendLayout();
            this.pnlAccountProp.SuspendLayout();
            this.pnlSearch.SuspendLayout();
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
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
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
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addClientToolStripMenuItem.Text = "Add client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
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
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // allTransacionsToolStripMenuItem
            // 
            this.allTransacionsToolStripMenuItem.Name = "allTransacionsToolStripMenuItem";
            this.allTransacionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.allTransacionsToolStripMenuItem.Text = "All transacions";
            // 
            // withdrawTransactionsToolStripMenuItem
            // 
            this.withdrawTransactionsToolStripMenuItem.Name = "withdrawTransactionsToolStripMenuItem";
            this.withdrawTransactionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.withdrawTransactionsToolStripMenuItem.Text = "Withdraw transactions";
            // 
            // depositTransactionsToolStripMenuItem
            // 
            this.depositTransactionsToolStripMenuItem.Name = "depositTransactionsToolStripMenuItem";
            this.depositTransactionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.depositTransactionsToolStripMenuItem.Text = "Deposit transactions";
            // 
            // transferTransactionsToolStripMenuItem
            // 
            this.transferTransactionsToolStripMenuItem.Name = "transferTransactionsToolStripMenuItem";
            this.transferTransactionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.transferTransactionsToolStripMenuItem.Text = "Transfer transactions";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgAccount,
            this.dgName,
            this.dgSurname,
            this.dgAddress,
            this.dgMail,
            this.dgBalance,
            this.dgCurrency,
            this.dgEnabled});
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 219);
            this.dataGridView1.TabIndex = 3;
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
            this.dgAccount.Width = 120;
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
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // dgMail
            // 
            this.dgMail.HeaderText = "Mail";
            this.dgMail.Name = "dgMail";
            this.dgMail.ReadOnly = true;
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
            // dgEnabled
            // 
            this.dgEnabled.HeaderText = "Enabled";
            this.dgEnabled.Name = "dgEnabled";
            this.dgEnabled.ReadOnly = true;
            this.dgEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlRegEdit
            // 
            this.pnlRegEdit.Controls.Add(this.btnAccountProp);
            this.pnlRegEdit.Controls.Add(this.chkbEnabled);
            this.pnlRegEdit.Controls.Add(this.cbMember);
            this.pnlRegEdit.Controls.Add(this.lbMember);
            this.pnlRegEdit.Controls.Add(this.cbCurrency);
            this.pnlRegEdit.Controls.Add(this.lbCurrency);
            this.pnlRegEdit.Controls.Add(this.btnCancel);
            this.pnlRegEdit.Controls.Add(this.btnAdd);
            this.pnlRegEdit.Controls.Add(this.tbPhone);
            this.pnlRegEdit.Controls.Add(this.lbPhone);
            this.pnlRegEdit.Controls.Add(this.tbMail);
            this.pnlRegEdit.Controls.Add(this.lbMail);
            this.pnlRegEdit.Controls.Add(this.tbAge);
            this.pnlRegEdit.Controls.Add(this.lbAge);
            this.pnlRegEdit.Controls.Add(this.tbSurname);
            this.pnlRegEdit.Controls.Add(this.lbSurname);
            this.pnlRegEdit.Controls.Add(this.tbName);
            this.pnlRegEdit.Controls.Add(this.lbName);
            this.pnlRegEdit.Location = new System.Drawing.Point(12, 369);
            this.pnlRegEdit.Name = "pnlRegEdit";
            this.pnlRegEdit.Size = new System.Drawing.Size(349, 309);
            this.pnlRegEdit.TabIndex = 5;
            this.pnlRegEdit.Visible = false;
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
            this.btnSearch.Location = new System.Drawing.Point(6, 280);
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
            this.pnlAccountProp.Location = new System.Drawing.Point(367, 553);
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
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lbSearchEnabled);
            this.pnlSearch.Controls.Add(this.cbSearchEnabled);
            this.pnlSearch.Controls.Add(this.lbSearchBalance);
            this.pnlSearch.Controls.Add(this.lbSearchSurname);
            this.pnlSearch.Controls.Add(this.lbSearchName);
            this.pnlSearch.Controls.Add(this.lbSearchAcc);
            this.pnlSearch.Controls.Add(this.lbSearchID);
            this.pnlSearch.Controls.Add(this.tbSearchBalance);
            this.pnlSearch.Controls.Add(this.tbSearchSurname);
            this.pnlSearch.Controls.Add(this.tbSearchName);
            this.pnlSearch.Controls.Add(this.tbSearchAcc);
            this.pnlSearch.Controls.Add(this.tbSearchID);
            this.pnlSearch.Controls.Add(this.dataGridView1);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(12, 27);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(934, 336);
            this.pnlSearch.TabIndex = 8;
            this.pnlSearch.Visible = false;
            // 
            // lbSearchEnabled
            // 
            this.lbSearchEnabled.AutoSize = true;
            this.lbSearchEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchEnabled.Location = new System.Drawing.Point(762, 8);
            this.lbSearchEnabled.Name = "lbSearchEnabled";
            this.lbSearchEnabled.Size = new System.Drawing.Size(62, 16);
            this.lbSearchEnabled.TabIndex = 30;
            this.lbSearchEnabled.Text = "Enabled:";
            // 
            // cbSearchEnabled
            // 
            this.cbSearchEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchEnabled.FormattingEnabled = true;
            this.cbSearchEnabled.Items.AddRange(new object[] {
            "All",
            "Enabled",
            "Disabled"});
            this.cbSearchEnabled.Location = new System.Drawing.Point(765, 29);
            this.cbSearchEnabled.Name = "cbSearchEnabled";
            this.cbSearchEnabled.Size = new System.Drawing.Size(121, 21);
            this.cbSearchEnabled.TabIndex = 19;
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
            // BankApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 690);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlAccountProp);
            this.Controls.Add(this.pnlRegEdit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BankApplication";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlRegEdit.ResumeLayout(false);
            this.pnlRegEdit.PerformLayout();
            this.pnlAccountProp.ResumeLayout(false);
            this.pnlAccountProp.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlRegEdit;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCurrency;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgEnabled;
        private System.Windows.Forms.Button btnAccountProp;
        private System.Windows.Forms.Panel pnlAccountProp;
        private System.Windows.Forms.TextBox tbSetBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox tbEditAccount;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox tbEditID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel pnlSearch;
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
        private System.Windows.Forms.Label lbSearchEnabled;
        private System.Windows.Forms.ComboBox cbSearchEnabled;
    }
}

