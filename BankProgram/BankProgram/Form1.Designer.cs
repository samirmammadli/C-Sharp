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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTransacionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 219);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add new client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbEnabled);
            this.panel1.Controls.Add(this.cbMember);
            this.panel1.Controls.Add(this.lbMember);
            this.panel1.Controls.Add(this.cbCurrency);
            this.panel1.Controls.Add(this.lbCurrency);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.lbMail);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.lbAge);
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Controls.Add(this.lbSurname);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(245, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 309);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(122, 252);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addClientToolStripMenuItem.Text = "Add client";
            // 
            // searchClientToolStripMenuItem
            // 
            this.searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            this.searchClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchClientToolStripMenuItem.Text = "Search client";
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
            // 
            // BankApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BankApplication";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btnLoad;
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
    }
}

