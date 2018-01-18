using System;
using System.Collections.Generic;
using System.Drawing;

namespace MoneFeWinForms
{
    partial class MoneFy
    {
        private Dictionary<string, Image> Images { get; set; }
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

        private void LoadImages()
        {
            string path = Environment.CurrentDirectory + @"\Images\";
            Images = new Dictionary<string, Image>()
            {
                { "cars", Image.FromFile(path + "car.png") },
                { "clothes", Image.FromFile(path + "clothes.png") },
                { "eating_out", Image.FromFile(path + "eating_out.png") },
                { "entertainment", Image.FromFile(path + "entertainment.png") },
                { "food", Image.FromFile(path + "food.png") },
                { "gifts", Image.FromFile(path + "gifts.png") },
                { "communications", Image.FromFile(path + "communications.png") },
                { "health", Image.FromFile(path + "health.png") },
                { "house", Image.FromFile(path + "house.png") },
                { "sports", Image.FromFile(path + "sports.png") },
                { "taxi", Image.FromFile(path + "taxi.png") },
                { "transport", Image.FromFile(path + "transport.png") }
            };

        }

        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneFy));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnClothes = new System.Windows.Forms.Button();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnEntertainment = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnGifts = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnEatingOut = new System.Windows.Forms.Button();
            this.btnHouse = new System.Windows.Forms.Button();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnTaxi = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnMainEditAcc = new System.Windows.Forms.Button();
            this.lbSelectRange = new System.Windows.Forms.Label();
            this.cbMainAccount = new System.Windows.Forms.ComboBox();
            this.cbSelectRange = new System.Windows.Forms.ComboBox();
            this.lbMainAccount = new System.Windows.Forms.Label();
            this.tbTotalBalance = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.pnlOutcome = new System.Windows.Forms.Panel();
            this.lbOutcomeBalanceValue = new System.Windows.Forms.Label();
            this.lbOutcome = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lbIncomeBalanceValue = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipCategory = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbAddToCategory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.pbSelectedCategoryImg = new System.Windows.Forms.PictureBox();
            this.buttonDot = new System.Windows.Forms.Button();
            this.pnlAddAmount = new System.Windows.Forms.Panel();
            this.btnAddCategoryCancel = new System.Windows.Forms.Button();
            this.toolTipInterface = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAddAcount = new System.Windows.Forms.Panel();
            this.lbAddAccBalance = new System.Windows.Forms.Label();
            this.cbAddAccCurr = new System.Windows.Forms.ComboBox();
            this.lbAddAccCurr = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.tbAddAccName = new System.Windows.Forms.TextBox();
            this.cbAddCategoryCurrency = new System.Windows.Forms.ComboBox();
            this.lbAddCategoryCurrency = new System.Windows.Forms.Label();
            this.pnlAddToCategory = new System.Windows.Forms.Panel();
            this.lbAddCategoryDate = new System.Windows.Forms.Label();
            this.dtpAddCategory = new System.Windows.Forms.DateTimePicker();
            this.tbAddCategoryNote = new System.Windows.Forms.TextBox();
            this.lbAddCategoryNote = new System.Windows.Forms.Label();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.cbSelectAccount = new System.Windows.Forms.ComboBox();
            this.lbSelectAccount = new System.Windows.Forms.Label();
            this.pnlEditAccount = new System.Windows.Forms.Panel();
            this.cbEditAccCurrency = new System.Windows.Forms.ComboBox();
            this.btnEditAccSave = new System.Windows.Forms.Button();
            this.lbEditAccCurrency = new System.Windows.Forms.Label();
            this.btnEditAccCancel = new System.Windows.Forms.Button();
            this.btnEditAccDelete = new System.Windows.Forms.Button();
            this.cbEditAccAcc = new System.Windows.Forms.ComboBox();
            this.lbEditAccAcc = new System.Windows.Forms.Label();
            this.pnlAddToBalance = new System.Windows.Forms.Panel();
            this.lbAddToBalanceAcc = new System.Windows.Forms.Label();
            this.cbAddToBalanceAcc = new System.Windows.Forms.ComboBox();
            this.lbAddToBalanceNote = new System.Windows.Forms.Label();
            this.tbAddToBalanceNote = new System.Windows.Forms.TextBox();
            this.lbAddToBalanceCurr = new System.Windows.Forms.Label();
            this.cbAddToBalanceCurr = new System.Windows.Forms.ComboBox();
            this.dtpAddToBalance = new System.Windows.Forms.DateTimePicker();
            this.lbAddToBalanceDate = new System.Windows.Forms.Label();
            this.lbTotalBalance = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlOutcome.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCategoryImg)).BeginInit();
            this.pnlAddAmount.SuspendLayout();
            this.pnlAddAcount.SuspendLayout();
            this.pnlAddToCategory.SuspendLayout();
            this.pnlEditAccount.SuspendLayout();
            this.pnlAddToBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(241, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 77);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.Transparent;
            this.btnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharge.ForeColor = System.Drawing.Color.Transparent;
            this.btnCharge.Image = ((System.Drawing.Image)(resources.GetObject("btnCharge.Image")));
            this.btnCharge.Location = new System.Drawing.Point(4, 400);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(77, 77);
            this.btnCharge.TabIndex = 13;
            this.btnCharge.UseVisualStyleBackColor = false;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // btnClothes
            // 
            this.btnClothes.BackColor = System.Drawing.Color.Transparent;
            this.btnClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClothes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClothes.Image = ((System.Drawing.Image)(resources.GetObject("btnClothes.Image")));
            this.btnClothes.Location = new System.Drawing.Point(84, 97);
            this.btnClothes.Name = "btnClothes";
            this.btnClothes.Size = new System.Drawing.Size(74, 64);
            this.btnClothes.TabIndex = 2;
            this.btnClothes.UseVisualStyleBackColor = false;
            this.btnClothes.Click += new System.EventHandler(this.btnClothes_Click);
            // 
            // btnCommunication
            // 
            this.btnCommunication.BackColor = System.Drawing.Color.Transparent;
            this.btnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunication.ForeColor = System.Drawing.Color.Transparent;
            this.btnCommunication.Image = ((System.Drawing.Image)(resources.GetObject("btnCommunication.Image")));
            this.btnCommunication.Location = new System.Drawing.Point(164, 167);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(74, 64);
            this.btnCommunication.TabIndex = 7;
            this.btnCommunication.UseVisualStyleBackColor = false;
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCar.Image")));
            this.btnCar.Location = new System.Drawing.Point(4, 97);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(74, 64);
            this.btnCar.TabIndex = 1;
            this.btnCar.Tag = "";
            this.toolTipCategory.SetToolTip(this.btnCar, "Car");
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnEntertainment
            // 
            this.btnEntertainment.BackColor = System.Drawing.Color.Transparent;
            this.btnEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntertainment.ForeColor = System.Drawing.Color.Transparent;
            this.btnEntertainment.Image = ((System.Drawing.Image)(resources.GetObject("btnEntertainment.Image")));
            this.btnEntertainment.Location = new System.Drawing.Point(241, 97);
            this.btnEntertainment.Name = "btnEntertainment";
            this.btnEntertainment.Size = new System.Drawing.Size(74, 64);
            this.btnEntertainment.TabIndex = 4;
            this.btnEntertainment.UseVisualStyleBackColor = false;
            this.btnEntertainment.Click += new System.EventHandler(this.btnEntertainment_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.Transparent;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.Location = new System.Drawing.Point(7, 167);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(74, 64);
            this.btnFood.TabIndex = 5;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnGifts
            // 
            this.btnGifts.BackColor = System.Drawing.Color.Transparent;
            this.btnGifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGifts.ForeColor = System.Drawing.Color.Transparent;
            this.btnGifts.Image = ((System.Drawing.Image)(resources.GetObject("btnGifts.Image")));
            this.btnGifts.Location = new System.Drawing.Point(84, 167);
            this.btnGifts.Name = "btnGifts";
            this.btnGifts.Size = new System.Drawing.Size(74, 64);
            this.btnGifts.TabIndex = 6;
            this.btnGifts.UseVisualStyleBackColor = false;
            this.btnGifts.Click += new System.EventHandler(this.btnGifts_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.Transparent;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.ForeColor = System.Drawing.Color.Transparent;
            this.btnHealth.Image = ((System.Drawing.Image)(resources.GetObject("btnHealth.Image")));
            this.btnHealth.Location = new System.Drawing.Point(244, 167);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(74, 64);
            this.btnHealth.TabIndex = 8;
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnEatingOut
            // 
            this.btnEatingOut.BackColor = System.Drawing.Color.Transparent;
            this.btnEatingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatingOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnEatingOut.Image = ((System.Drawing.Image)(resources.GetObject("btnEatingOut.Image")));
            this.btnEatingOut.Location = new System.Drawing.Point(164, 97);
            this.btnEatingOut.Name = "btnEatingOut";
            this.btnEatingOut.Size = new System.Drawing.Size(74, 64);
            this.btnEatingOut.TabIndex = 3;
            this.btnEatingOut.UseVisualStyleBackColor = false;
            this.btnEatingOut.Click += new System.EventHandler(this.btnEatingOut_Click);
            // 
            // btnHouse
            // 
            this.btnHouse.BackColor = System.Drawing.Color.Transparent;
            this.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouse.ForeColor = System.Drawing.Color.Transparent;
            this.btnHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnHouse.Image")));
            this.btnHouse.Location = new System.Drawing.Point(4, 237);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(74, 64);
            this.btnHouse.TabIndex = 9;
            this.btnHouse.UseVisualStyleBackColor = false;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            // 
            // btnTransport
            // 
            this.btnTransport.BackColor = System.Drawing.Color.Transparent;
            this.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransport.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransport.Image = ((System.Drawing.Image)(resources.GetObject("btnTransport.Image")));
            this.btnTransport.Location = new System.Drawing.Point(244, 237);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(74, 64);
            this.btnTransport.TabIndex = 12;
            this.btnTransport.UseVisualStyleBackColor = false;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // btnTaxi
            // 
            this.btnTaxi.BackColor = System.Drawing.Color.Transparent;
            this.btnTaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxi.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaxi.Image")));
            this.btnTaxi.Location = new System.Drawing.Point(164, 237);
            this.btnTaxi.Name = "btnTaxi";
            this.btnTaxi.Size = new System.Drawing.Size(74, 64);
            this.btnTaxi.TabIndex = 11;
            this.btnTaxi.UseVisualStyleBackColor = false;
            this.btnTaxi.Click += new System.EventHandler(this.btnTaxi_Click);
            // 
            // btnSport
            // 
            this.btnSport.BackColor = System.Drawing.Color.Transparent;
            this.btnSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSport.ForeColor = System.Drawing.Color.Transparent;
            this.btnSport.Image = ((System.Drawing.Image)(resources.GetObject("btnSport.Image")));
            this.btnSport.Location = new System.Drawing.Point(84, 237);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(74, 64);
            this.btnSport.TabIndex = 10;
            this.btnSport.UseVisualStyleBackColor = false;
            this.btnSport.Click += new System.EventHandler(this.btnSport_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lbTotalBalance);
            this.pnlMain.Controls.Add(this.btnMainEditAcc);
            this.pnlMain.Controls.Add(this.lbSelectRange);
            this.pnlMain.Controls.Add(this.cbMainAccount);
            this.pnlMain.Controls.Add(this.cbSelectRange);
            this.pnlMain.Controls.Add(this.lbMainAccount);
            this.pnlMain.Controls.Add(this.tbTotalBalance);
            this.pnlMain.Controls.Add(this.btnAddAccount);
            this.pnlMain.Controls.Add(this.pnlOutcome);
            this.pnlMain.Controls.Add(this.pnlIncome);
            this.pnlMain.Controls.Add(this.btnCar);
            this.pnlMain.Controls.Add(this.btnTransport);
            this.pnlMain.Controls.Add(this.btnGifts);
            this.pnlMain.Controls.Add(this.btnFood);
            this.pnlMain.Controls.Add(this.btnCommunication);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.btnTaxi);
            this.pnlMain.Controls.Add(this.btnCharge);
            this.pnlMain.Controls.Add(this.btnSport);
            this.pnlMain.Controls.Add(this.btnClothes);
            this.pnlMain.Controls.Add(this.btnHouse);
            this.pnlMain.Controls.Add(this.btnEatingOut);
            this.pnlMain.Controls.Add(this.btnEntertainment);
            this.pnlMain.Controls.Add(this.btnHealth);
            this.pnlMain.Location = new System.Drawing.Point(12, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(322, 485);
            this.pnlMain.TabIndex = 15;
            // 
            // btnMainEditAcc
            // 
            this.btnMainEditAcc.Location = new System.Drawing.Point(187, 72);
            this.btnMainEditAcc.Name = "btnMainEditAcc";
            this.btnMainEditAcc.Size = new System.Drawing.Size(128, 23);
            this.btnMainEditAcc.TabIndex = 43;
            this.btnMainEditAcc.Text = "Edit";
            this.btnMainEditAcc.UseVisualStyleBackColor = true;
            this.btnMainEditAcc.Click += new System.EventHandler(this.btnMainEditAcc_Click);
            // 
            // lbSelectRange
            // 
            this.lbSelectRange.AutoSize = true;
            this.lbSelectRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelectRange.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbSelectRange.Location = new System.Drawing.Point(79, 10);
            this.lbSelectRange.Name = "lbSelectRange";
            this.lbSelectRange.Size = new System.Drawing.Size(77, 24);
            this.lbSelectRange.TabIndex = 42;
            this.lbSelectRange.Text = "Period:";
            // 
            // cbMainAccount
            // 
            this.cbMainAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMainAccount.FormattingEnabled = true;
            this.cbMainAccount.Location = new System.Drawing.Point(187, 44);
            this.cbMainAccount.Name = "cbMainAccount";
            this.cbMainAccount.Size = new System.Drawing.Size(128, 21);
            this.cbMainAccount.TabIndex = 40;
            this.cbMainAccount.SelectionChangeCommitted += new System.EventHandler(this.cbMainAccount_SelectionChangeCommitted);
            // 
            // cbSelectRange
            // 
            this.cbSelectRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectRange.FormattingEnabled = true;
            this.cbSelectRange.Location = new System.Drawing.Point(83, 44);
            this.cbSelectRange.Name = "cbSelectRange";
            this.cbSelectRange.Size = new System.Drawing.Size(93, 21);
            this.cbSelectRange.TabIndex = 41;
            this.cbSelectRange.SelectedIndexChanged += new System.EventHandler(this.cbSelectRange_SelectedIndexChanged);
            // 
            // lbMainAccount
            // 
            this.lbMainAccount.AutoSize = true;
            this.lbMainAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMainAccount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbMainAccount.Location = new System.Drawing.Point(198, 10);
            this.lbMainAccount.Name = "lbMainAccount";
            this.lbMainAccount.Size = new System.Drawing.Size(93, 24);
            this.lbMainAccount.TabIndex = 39;
            this.lbMainAccount.Text = "Account:";
            // 
            // tbTotalBalance
            // 
            this.tbTotalBalance.BackColor = System.Drawing.Color.MintCream;
            this.tbTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalBalance.Location = new System.Drawing.Point(88, 431);
            this.tbTotalBalance.Name = "tbTotalBalance";
            this.tbTotalBalance.ReadOnly = true;
            this.tbTotalBalance.Size = new System.Drawing.Size(150, 19);
            this.tbTotalBalance.TabIndex = 21;
            this.tbTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTotalBalance.TextChanged += new System.EventHandler(this.tbTotalBalance_TextChanged);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(74, 64);
            this.btnAddAccount.TabIndex = 19;
            this.btnAddAccount.Tag = "";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // pnlOutcome
            // 
            this.pnlOutcome.BackColor = System.Drawing.Color.Crimson;
            this.pnlOutcome.Controls.Add(this.lbOutcomeBalanceValue);
            this.pnlOutcome.Controls.Add(this.lbOutcome);
            this.pnlOutcome.Location = new System.Drawing.Point(4, 352);
            this.pnlOutcome.Name = "pnlOutcome";
            this.pnlOutcome.Size = new System.Drawing.Size(314, 39);
            this.pnlOutcome.TabIndex = 18;
            // 
            // lbOutcomeBalanceValue
            // 
            this.lbOutcomeBalanceValue.AutoSize = true;
            this.lbOutcomeBalanceValue.BackColor = System.Drawing.Color.Transparent;
            this.lbOutcomeBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbOutcomeBalanceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbOutcomeBalanceValue.Location = new System.Drawing.Point(90, 9);
            this.lbOutcomeBalanceValue.Name = "lbOutcomeBalanceValue";
            this.lbOutcomeBalanceValue.Size = new System.Drawing.Size(59, 20);
            this.lbOutcomeBalanceValue.TabIndex = 1;
            this.lbOutcomeBalanceValue.Text = "17000";
            // 
            // lbOutcome
            // 
            this.lbOutcome.AutoSize = true;
            this.lbOutcome.BackColor = System.Drawing.Color.Transparent;
            this.lbOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbOutcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbOutcome.Location = new System.Drawing.Point(3, 9);
            this.lbOutcome.Name = "lbOutcome";
            this.lbOutcome.Size = new System.Drawing.Size(81, 20);
            this.lbOutcome.TabIndex = 0;
            this.lbOutcome.Text = "Outcome";
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIncome.BackgroundImage")));
            this.pnlIncome.Controls.Add(this.lbIncomeBalanceValue);
            this.pnlIncome.Controls.Add(this.lbIncome);
            this.pnlIncome.Location = new System.Drawing.Point(4, 307);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(314, 39);
            this.pnlIncome.TabIndex = 17;
            // 
            // lbIncomeBalanceValue
            // 
            this.lbIncomeBalanceValue.AutoSize = true;
            this.lbIncomeBalanceValue.BackColor = System.Drawing.Color.Transparent;
            this.lbIncomeBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbIncomeBalanceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIncomeBalanceValue.Location = new System.Drawing.Point(90, 9);
            this.lbIncomeBalanceValue.Name = "lbIncomeBalanceValue";
            this.lbIncomeBalanceValue.Size = new System.Drawing.Size(59, 20);
            this.lbIncomeBalanceValue.TabIndex = 1;
            this.lbIncomeBalanceValue.Text = "17000";
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.BackColor = System.Drawing.Color.Transparent;
            this.lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbIncome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIncome.Location = new System.Drawing.Point(3, 9);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(68, 20);
            this.lbIncome.TabIndex = 0;
            this.lbIncome.Text = "Income";
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.Location = new System.Drawing.Point(1058, 533);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(69, 64);
            this.btnCalendar.TabIndex = 18;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1370, 24);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "File";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.russianToolStripMenuItem.Text = "Русский";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(700, 313);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Categories";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(326, 225);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(5, 212);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(154, 35);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAmount.Location = new System.Drawing.Point(5, 4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(312, 26);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.Text = "0";
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.Enter += new System.EventHandler(this.tbAmount_Enter);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            this.tbAmount.Leave += new System.EventHandler(this.tbAmount_Leave);
            // 
            // lbAddToCategory
            // 
            this.lbAddToCategory.AutoSize = true;
            this.lbAddToCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToCategory.ForeColor = System.Drawing.Color.Green;
            this.lbAddToCategory.Location = new System.Drawing.Point(2, 25);
            this.lbAddToCategory.Name = "lbAddToCategory";
            this.lbAddToCategory.Size = new System.Drawing.Size(153, 24);
            this.lbAddToCategory.TabIndex = 19;
            this.lbAddToCategory.Text = "Add To Category";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(5, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(111, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(217, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(5, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.DarkGreen;
            this.button8.Location = new System.Drawing.Point(111, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 35);
            this.button8.TabIndex = 28;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.DarkGreen;
            this.button7.Location = new System.Drawing.Point(5, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.TabIndex = 27;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.DarkGreen;
            this.button6.Location = new System.Drawing.Point(217, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.TabIndex = 26;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.DarkGreen;
            this.button5.Location = new System.Drawing.Point(111, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.Color.DarkGreen;
            this.button0.Location = new System.Drawing.Point(5, 171);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(100, 35);
            this.button0.TabIndex = 30;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.DarkGreen;
            this.button9.Location = new System.Drawing.Point(217, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 35);
            this.button9.TabIndex = 29;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnErase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnErase.Location = new System.Drawing.Point(217, 171);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(100, 36);
            this.btnErase.TabIndex = 31;
            this.btnErase.Text = "<-";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // pbSelectedCategoryImg
            // 
            this.pbSelectedCategoryImg.Location = new System.Drawing.Point(242, 12);
            this.pbSelectedCategoryImg.Name = "pbSelectedCategoryImg";
            this.pbSelectedCategoryImg.Size = new System.Drawing.Size(75, 68);
            this.pbSelectedCategoryImg.TabIndex = 32;
            this.pbSelectedCategoryImg.TabStop = false;
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDot.Location = new System.Drawing.Point(111, 171);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(100, 35);
            this.buttonDot.TabIndex = 34;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // pnlAddAmount
            // 
            this.pnlAddAmount.Controls.Add(this.btnAddCategoryCancel);
            this.pnlAddAmount.Controls.Add(this.tbAmount);
            this.pnlAddAmount.Controls.Add(this.btnAddCategory);
            this.pnlAddAmount.Controls.Add(this.buttonDot);
            this.pnlAddAmount.Controls.Add(this.button1);
            this.pnlAddAmount.Controls.Add(this.button2);
            this.pnlAddAmount.Controls.Add(this.button3);
            this.pnlAddAmount.Controls.Add(this.btnErase);
            this.pnlAddAmount.Controls.Add(this.button4);
            this.pnlAddAmount.Controls.Add(this.button0);
            this.pnlAddAmount.Controls.Add(this.button5);
            this.pnlAddAmount.Controls.Add(this.button9);
            this.pnlAddAmount.Controls.Add(this.button6);
            this.pnlAddAmount.Controls.Add(this.button8);
            this.pnlAddAmount.Controls.Add(this.button7);
            this.pnlAddAmount.Location = new System.Drawing.Point(348, 309);
            this.pnlAddAmount.Name = "pnlAddAmount";
            this.pnlAddAmount.Size = new System.Drawing.Size(320, 251);
            this.pnlAddAmount.TabIndex = 36;
            this.pnlAddAmount.Visible = false;
            // 
            // btnAddCategoryCancel
            // 
            this.btnAddCategoryCancel.Location = new System.Drawing.Point(163, 212);
            this.btnAddCategoryCancel.Name = "btnAddCategoryCancel";
            this.btnAddCategoryCancel.Size = new System.Drawing.Size(154, 35);
            this.btnAddCategoryCancel.TabIndex = 35;
            this.btnAddCategoryCancel.Text = "Cancel";
            this.btnAddCategoryCancel.UseVisualStyleBackColor = true;
            this.btnAddCategoryCancel.Click += new System.EventHandler(this.btnAddCategoryCancel_Click);
            // 
            // pnlAddAcount
            // 
            this.pnlAddAcount.Controls.Add(this.lbAddAccBalance);
            this.pnlAddAcount.Controls.Add(this.cbAddAccCurr);
            this.pnlAddAcount.Controls.Add(this.lbAddAccCurr);
            this.pnlAddAcount.Controls.Add(this.lbAccountName);
            this.pnlAddAcount.Controls.Add(this.tbAddAccName);
            this.pnlAddAcount.Location = new System.Drawing.Point(700, 78);
            this.pnlAddAcount.Name = "pnlAddAcount";
            this.pnlAddAcount.Size = new System.Drawing.Size(317, 210);
            this.pnlAddAcount.TabIndex = 37;
            // 
            // lbAddAccBalance
            // 
            this.lbAddAccBalance.AutoSize = true;
            this.lbAddAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddAccBalance.ForeColor = System.Drawing.Color.Green;
            this.lbAddAccBalance.Location = new System.Drawing.Point(3, 175);
            this.lbAddAccBalance.Name = "lbAddAccBalance";
            this.lbAddAccBalance.Size = new System.Drawing.Size(83, 24);
            this.lbAddAccBalance.TabIndex = 41;
            this.lbAddAccBalance.Text = "Balance:";
            // 
            // cbAddAccCurr
            // 
            this.cbAddAccCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddAccCurr.FormattingEnabled = true;
            this.cbAddAccCurr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAddAccCurr.Location = new System.Drawing.Point(193, 46);
            this.cbAddAccCurr.Name = "cbAddAccCurr";
            this.cbAddAccCurr.Size = new System.Drawing.Size(121, 21);
            this.cbAddAccCurr.TabIndex = 40;
            // 
            // lbAddAccCurr
            // 
            this.lbAddAccCurr.AutoSize = true;
            this.lbAddAccCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddAccCurr.ForeColor = System.Drawing.Color.Chocolate;
            this.lbAddAccCurr.Location = new System.Drawing.Point(3, 46);
            this.lbAddAccCurr.Name = "lbAddAccCurr";
            this.lbAddAccCurr.Size = new System.Drawing.Size(101, 24);
            this.lbAddAccCurr.TabIndex = 39;
            this.lbAddAccCurr.Text = "Currency:";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccountName.ForeColor = System.Drawing.Color.Green;
            this.lbAccountName.Location = new System.Drawing.Point(80, 76);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(141, 24);
            this.lbAccountName.TabIndex = 20;
            this.lbAccountName.Text = "Account Name:";
            // 
            // tbAddAccName
            // 
            this.tbAddAccName.Location = new System.Drawing.Point(3, 115);
            this.tbAddAccName.Name = "tbAddAccName";
            this.tbAddAccName.Size = new System.Drawing.Size(311, 20);
            this.tbAddAccName.TabIndex = 0;
            // 
            // cbAddCategoryCurrency
            // 
            this.cbAddCategoryCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCategoryCurrency.FormattingEnabled = true;
            this.cbAddCategoryCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAddCategoryCurrency.Location = new System.Drawing.Point(196, 120);
            this.cbAddCategoryCurrency.Name = "cbAddCategoryCurrency";
            this.cbAddCategoryCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbAddCategoryCurrency.TabIndex = 36;
            // 
            // lbAddCategoryCurrency
            // 
            this.lbAddCategoryCurrency.AutoSize = true;
            this.lbAddCategoryCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddCategoryCurrency.ForeColor = System.Drawing.Color.Chocolate;
            this.lbAddCategoryCurrency.Location = new System.Drawing.Point(3, 115);
            this.lbAddCategoryCurrency.Name = "lbAddCategoryCurrency";
            this.lbAddCategoryCurrency.Size = new System.Drawing.Size(101, 24);
            this.lbAddCategoryCurrency.TabIndex = 35;
            this.lbAddCategoryCurrency.Text = "Currency:";
            // 
            // pnlAddToCategory
            // 
            this.pnlAddToCategory.Controls.Add(this.lbAddCategoryDate);
            this.pnlAddToCategory.Controls.Add(this.dtpAddCategory);
            this.pnlAddToCategory.Controls.Add(this.tbAddCategoryNote);
            this.pnlAddToCategory.Controls.Add(this.lbAddCategoryNote);
            this.pnlAddToCategory.Controls.Add(this.cbSelectCategory);
            this.pnlAddToCategory.Controls.Add(this.cbAddCategoryCurrency);
            this.pnlAddToCategory.Controls.Add(this.cbSelectAccount);
            this.pnlAddToCategory.Controls.Add(this.lbSelectAccount);
            this.pnlAddToCategory.Controls.Add(this.lbAddCategoryCurrency);
            this.pnlAddToCategory.Controls.Add(this.pbSelectedCategoryImg);
            this.pnlAddToCategory.Controls.Add(this.lbAddToCategory);
            this.pnlAddToCategory.Location = new System.Drawing.Point(348, 75);
            this.pnlAddToCategory.Name = "pnlAddToCategory";
            this.pnlAddToCategory.Size = new System.Drawing.Size(320, 228);
            this.pnlAddToCategory.TabIndex = 38;
            // 
            // lbAddCategoryDate
            // 
            this.lbAddCategoryDate.AutoSize = true;
            this.lbAddCategoryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddCategoryDate.ForeColor = System.Drawing.Color.Sienna;
            this.lbAddCategoryDate.Location = new System.Drawing.Point(3, 139);
            this.lbAddCategoryDate.Name = "lbAddCategoryDate";
            this.lbAddCategoryDate.Size = new System.Drawing.Size(58, 24);
            this.lbAddCategoryDate.TabIndex = 40;
            this.lbAddCategoryDate.Text = "Date:";
            // 
            // dtpAddCategory
            // 
            this.dtpAddCategory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddCategory.Location = new System.Drawing.Point(196, 147);
            this.dtpAddCategory.MaxDate = new System.DateTime(2018, 1, 18, 1, 8, 43, 904);
            this.dtpAddCategory.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpAddCategory.Name = "dtpAddCategory";
            this.dtpAddCategory.Size = new System.Drawing.Size(121, 20);
            this.dtpAddCategory.TabIndex = 39;
            this.dtpAddCategory.Value = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
            // 
            // tbAddCategoryNote
            // 
            this.tbAddCategoryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddCategoryNote.Location = new System.Drawing.Point(3, 199);
            this.tbAddCategoryNote.Name = "tbAddCategoryNote";
            this.tbAddCategoryNote.Size = new System.Drawing.Size(311, 26);
            this.tbAddCategoryNote.TabIndex = 34;
            // 
            // lbAddCategoryNote
            // 
            this.lbAddCategoryNote.AutoSize = true;
            this.lbAddCategoryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddCategoryNote.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAddCategoryNote.Location = new System.Drawing.Point(2, 167);
            this.lbAddCategoryNote.Name = "lbAddCategoryNote";
            this.lbAddCategoryNote.Size = new System.Drawing.Size(104, 24);
            this.lbAddCategoryNote.TabIndex = 38;
            this.lbAddCategoryNote.Text = "Add Note:";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(7, 53);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(121, 21);
            this.cbSelectCategory.TabIndex = 37;
            this.cbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cbSelectCategory_SelectedIndexChanged);
            // 
            // cbSelectAccount
            // 
            this.cbSelectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectAccount.FormattingEnabled = true;
            this.cbSelectAccount.Location = new System.Drawing.Point(196, 91);
            this.cbSelectAccount.Name = "cbSelectAccount";
            this.cbSelectAccount.Size = new System.Drawing.Size(121, 21);
            this.cbSelectAccount.TabIndex = 34;
            // 
            // lbSelectAccount
            // 
            this.lbSelectAccount.AutoSize = true;
            this.lbSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelectAccount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbSelectAccount.Location = new System.Drawing.Point(2, 91);
            this.lbSelectAccount.Name = "lbSelectAccount";
            this.lbSelectAccount.Size = new System.Drawing.Size(93, 24);
            this.lbSelectAccount.TabIndex = 33;
            this.lbSelectAccount.Text = "Account:";
            // 
            // pnlEditAccount
            // 
            this.pnlEditAccount.Controls.Add(this.cbEditAccCurrency);
            this.pnlEditAccount.Controls.Add(this.btnEditAccSave);
            this.pnlEditAccount.Controls.Add(this.lbEditAccCurrency);
            this.pnlEditAccount.Controls.Add(this.btnEditAccCancel);
            this.pnlEditAccount.Controls.Add(this.btnEditAccDelete);
            this.pnlEditAccount.Controls.Add(this.cbEditAccAcc);
            this.pnlEditAccount.Controls.Add(this.lbEditAccAcc);
            this.pnlEditAccount.Location = new System.Drawing.Point(1023, 78);
            this.pnlEditAccount.Name = "pnlEditAccount";
            this.pnlEditAccount.Size = new System.Drawing.Size(326, 112);
            this.pnlEditAccount.TabIndex = 39;
            // 
            // cbEditAccCurrency
            // 
            this.cbEditAccCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditAccCurrency.FormattingEnabled = true;
            this.cbEditAccCurrency.Location = new System.Drawing.Point(193, 46);
            this.cbEditAccCurrency.Name = "cbEditAccCurrency";
            this.cbEditAccCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbEditAccCurrency.TabIndex = 49;
            // 
            // btnEditAccSave
            // 
            this.btnEditAccSave.Location = new System.Drawing.Point(9, 76);
            this.btnEditAccSave.Name = "btnEditAccSave";
            this.btnEditAccSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccSave.TabIndex = 48;
            this.btnEditAccSave.Text = "Save";
            this.btnEditAccSave.UseVisualStyleBackColor = true;
            this.btnEditAccSave.Click += new System.EventHandler(this.btnEditAccSave_Click);
            // 
            // lbEditAccCurrency
            // 
            this.lbEditAccCurrency.AutoSize = true;
            this.lbEditAccCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditAccCurrency.ForeColor = System.Drawing.Color.Chocolate;
            this.lbEditAccCurrency.Location = new System.Drawing.Point(3, 41);
            this.lbEditAccCurrency.Name = "lbEditAccCurrency";
            this.lbEditAccCurrency.Size = new System.Drawing.Size(101, 24);
            this.lbEditAccCurrency.TabIndex = 41;
            this.lbEditAccCurrency.Text = "Currency:";
            // 
            // btnEditAccCancel
            // 
            this.btnEditAccCancel.Location = new System.Drawing.Point(239, 76);
            this.btnEditAccCancel.Name = "btnEditAccCancel";
            this.btnEditAccCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccCancel.TabIndex = 47;
            this.btnEditAccCancel.Text = "Cancel";
            this.btnEditAccCancel.UseVisualStyleBackColor = true;
            this.btnEditAccCancel.Click += new System.EventHandler(this.btnEditAccCancel_Click);
            // 
            // btnEditAccDelete
            // 
            this.btnEditAccDelete.Location = new System.Drawing.Point(126, 76);
            this.btnEditAccDelete.Name = "btnEditAccDelete";
            this.btnEditAccDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccDelete.TabIndex = 46;
            this.btnEditAccDelete.Text = "Delete";
            this.btnEditAccDelete.UseVisualStyleBackColor = true;
            this.btnEditAccDelete.Click += new System.EventHandler(this.btnEditAccDelete_Click);
            // 
            // cbEditAccAcc
            // 
            this.cbEditAccAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditAccAcc.FormattingEnabled = true;
            this.cbEditAccAcc.Location = new System.Drawing.Point(193, 12);
            this.cbEditAccAcc.Name = "cbEditAccAcc";
            this.cbEditAccAcc.Size = new System.Drawing.Size(121, 21);
            this.cbEditAccAcc.TabIndex = 44;
            // 
            // lbEditAccAcc
            // 
            this.lbEditAccAcc.AutoSize = true;
            this.lbEditAccAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEditAccAcc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbEditAccAcc.Location = new System.Drawing.Point(3, 12);
            this.lbEditAccAcc.Name = "lbEditAccAcc";
            this.lbEditAccAcc.Size = new System.Drawing.Size(93, 24);
            this.lbEditAccAcc.TabIndex = 43;
            this.lbEditAccAcc.Text = "Account:";
            // 
            // pnlAddToBalance
            // 
            this.pnlAddToBalance.Controls.Add(this.lbAddToBalanceDate);
            this.pnlAddToBalance.Controls.Add(this.dtpAddToBalance);
            this.pnlAddToBalance.Controls.Add(this.cbAddToBalanceCurr);
            this.pnlAddToBalance.Controls.Add(this.lbAddToBalanceCurr);
            this.pnlAddToBalance.Controls.Add(this.tbAddToBalanceNote);
            this.pnlAddToBalance.Controls.Add(this.lbAddToBalanceNote);
            this.pnlAddToBalance.Controls.Add(this.cbAddToBalanceAcc);
            this.pnlAddToBalance.Controls.Add(this.lbAddToBalanceAcc);
            this.pnlAddToBalance.Location = new System.Drawing.Point(1023, 206);
            this.pnlAddToBalance.Name = "pnlAddToBalance";
            this.pnlAddToBalance.Size = new System.Drawing.Size(326, 154);
            this.pnlAddToBalance.TabIndex = 40;
            // 
            // lbAddToBalanceAcc
            // 
            this.lbAddToBalanceAcc.AutoSize = true;
            this.lbAddToBalanceAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToBalanceAcc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbAddToBalanceAcc.Location = new System.Drawing.Point(3, 4);
            this.lbAddToBalanceAcc.Name = "lbAddToBalanceAcc";
            this.lbAddToBalanceAcc.Size = new System.Drawing.Size(93, 24);
            this.lbAddToBalanceAcc.TabIndex = 50;
            this.lbAddToBalanceAcc.Text = "Account:";
            // 
            // cbAddToBalanceAcc
            // 
            this.cbAddToBalanceAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddToBalanceAcc.FormattingEnabled = true;
            this.cbAddToBalanceAcc.Location = new System.Drawing.Point(193, 4);
            this.cbAddToBalanceAcc.Name = "cbAddToBalanceAcc";
            this.cbAddToBalanceAcc.Size = new System.Drawing.Size(121, 21);
            this.cbAddToBalanceAcc.TabIndex = 51;
            // 
            // lbAddToBalanceNote
            // 
            this.lbAddToBalanceNote.AutoSize = true;
            this.lbAddToBalanceNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToBalanceNote.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAddToBalanceNote.Location = new System.Drawing.Point(5, 103);
            this.lbAddToBalanceNote.Name = "lbAddToBalanceNote";
            this.lbAddToBalanceNote.Size = new System.Drawing.Size(104, 24);
            this.lbAddToBalanceNote.TabIndex = 41;
            this.lbAddToBalanceNote.Text = "Add Note:";
            // 
            // tbAddToBalanceNote
            // 
            this.tbAddToBalanceNote.Location = new System.Drawing.Point(7, 130);
            this.tbAddToBalanceNote.Name = "tbAddToBalanceNote";
            this.tbAddToBalanceNote.Size = new System.Drawing.Size(311, 20);
            this.tbAddToBalanceNote.TabIndex = 41;
            // 
            // lbAddToBalanceCurr
            // 
            this.lbAddToBalanceCurr.AutoSize = true;
            this.lbAddToBalanceCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToBalanceCurr.ForeColor = System.Drawing.Color.Chocolate;
            this.lbAddToBalanceCurr.Location = new System.Drawing.Point(3, 36);
            this.lbAddToBalanceCurr.Name = "lbAddToBalanceCurr";
            this.lbAddToBalanceCurr.Size = new System.Drawing.Size(101, 24);
            this.lbAddToBalanceCurr.TabIndex = 50;
            this.lbAddToBalanceCurr.Text = "Currency:";
            // 
            // cbAddToBalanceCurr
            // 
            this.cbAddToBalanceCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddToBalanceCurr.FormattingEnabled = true;
            this.cbAddToBalanceCurr.Location = new System.Drawing.Point(193, 36);
            this.cbAddToBalanceCurr.Name = "cbAddToBalanceCurr";
            this.cbAddToBalanceCurr.Size = new System.Drawing.Size(121, 21);
            this.cbAddToBalanceCurr.TabIndex = 52;
            // 
            // dtpAddToBalance
            // 
            this.dtpAddToBalance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddToBalance.Location = new System.Drawing.Point(193, 70);
            this.dtpAddToBalance.MaxDate = new System.DateTime(2018, 1, 18, 1, 8, 43, 904);
            this.dtpAddToBalance.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpAddToBalance.Name = "dtpAddToBalance";
            this.dtpAddToBalance.Size = new System.Drawing.Size(121, 20);
            this.dtpAddToBalance.TabIndex = 53;
            this.dtpAddToBalance.Value = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
            // 
            // lbAddToBalanceDate
            // 
            this.lbAddToBalanceDate.AutoSize = true;
            this.lbAddToBalanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToBalanceDate.ForeColor = System.Drawing.Color.Sienna;
            this.lbAddToBalanceDate.Location = new System.Drawing.Point(5, 68);
            this.lbAddToBalanceDate.Name = "lbAddToBalanceDate";
            this.lbAddToBalanceDate.Size = new System.Drawing.Size(58, 24);
            this.lbAddToBalanceDate.TabIndex = 41;
            this.lbAddToBalanceDate.Text = "Date:";
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.BackColor = System.Drawing.Color.MintCream;
            this.lbTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTotalBalance.Location = new System.Drawing.Point(91, 399);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(147, 19);
            this.lbTotalBalance.TabIndex = 41;
            this.lbTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MoneFy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1370, 641);
            this.Controls.Add(this.pnlAddToBalance);
            this.Controls.Add(this.pnlEditAccount);
            this.Controls.Add(this.pnlAddToCategory);
            this.Controls.Add(this.pnlAddAcount);
            this.Controls.Add(this.pnlAddAmount);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.btnCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MoneFy";
            this.Text = "MoneFy";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlOutcome.ResumeLayout(false);
            this.pnlOutcome.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCategoryImg)).EndInit();
            this.pnlAddAmount.ResumeLayout(false);
            this.pnlAddAmount.PerformLayout();
            this.pnlAddAcount.ResumeLayout(false);
            this.pnlAddAcount.PerformLayout();
            this.pnlAddToCategory.ResumeLayout(false);
            this.pnlAddToCategory.PerformLayout();
            this.pnlEditAccount.ResumeLayout(false);
            this.pnlEditAccount.PerformLayout();
            this.pnlAddToBalance.ResumeLayout(false);
            this.pnlAddToBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnClothes;
        private System.Windows.Forms.Button btnCommunication;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnEntertainment;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnGifts;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnEatingOut;
        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnTaxi;
        private System.Windows.Forms.Button btnSport;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lbIncomeBalanceValue;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTipCategory;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOutcome;
        private System.Windows.Forms.Label lbOutcomeBalanceValue;
        private System.Windows.Forms.Label lbOutcome;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbAddToCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.PictureBox pbSelectedCategoryImg;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Panel pnlAddAmount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ToolTip toolTipInterface;
        private System.Windows.Forms.Panel pnlAddAcount;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox tbAddAccName;
        private System.Windows.Forms.Panel pnlAddToCategory;
        private System.Windows.Forms.ComboBox cbAddCategoryCurrency;
        private System.Windows.Forms.Label lbAddCategoryCurrency;
        private System.Windows.Forms.ComboBox cbSelectAccount;
        private System.Windows.Forms.Label lbSelectAccount;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.TextBox tbAddCategoryNote;
        private System.Windows.Forms.Label lbAddCategoryNote;
        private System.Windows.Forms.ComboBox cbAddAccCurr;
        private System.Windows.Forms.Label lbAddAccCurr;
        private System.Windows.Forms.TextBox tbTotalBalance;
        private System.Windows.Forms.Label lbAddAccBalance;
        private System.Windows.Forms.Label lbMainAccount;
        private System.Windows.Forms.ComboBox cbMainAccount;
        private System.Windows.Forms.ComboBox cbSelectRange;
        private System.Windows.Forms.Label lbSelectRange;
        private System.Windows.Forms.DateTimePicker dtpAddCategory;
        private System.Windows.Forms.Label lbAddCategoryDate;
        private System.Windows.Forms.Panel pnlEditAccount;
        private System.Windows.Forms.ComboBox cbEditAccAcc;
        private System.Windows.Forms.Label lbEditAccAcc;
        private System.Windows.Forms.Button btnEditAccCancel;
        private System.Windows.Forms.Button btnEditAccDelete;
        private System.Windows.Forms.Button btnAddCategoryCancel;
        private System.Windows.Forms.Button btnEditAccSave;
        private System.Windows.Forms.Label lbEditAccCurrency;
        private System.Windows.Forms.ComboBox cbEditAccCurrency;
        private System.Windows.Forms.Button btnMainEditAcc;
        private System.Windows.Forms.Panel pnlAddToBalance;
        private System.Windows.Forms.ComboBox cbAddToBalanceAcc;
        private System.Windows.Forms.Label lbAddToBalanceAcc;
        private System.Windows.Forms.TextBox tbAddToBalanceNote;
        private System.Windows.Forms.Label lbAddToBalanceNote;
        private System.Windows.Forms.ComboBox cbAddToBalanceCurr;
        private System.Windows.Forms.Label lbAddToBalanceCurr;
        private System.Windows.Forms.Label lbAddToBalanceDate;
        private System.Windows.Forms.DateTimePicker dtpAddToBalance;
        private System.Windows.Forms.TextBox lbTotalBalance;
    }
}

