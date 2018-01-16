using System;
using System.Collections.Generic;
using System.Drawing;

namespace MoneFeWinForms
{
    partial class MoneFy
    {
        private Dictionary<string, Image> Images { get; set; }
        Image aha;
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

        private void LoadCategoriesChart()
        {
            foreach (var item in Monefy.Operations)
            {
                foreach (var oper in item.Value)
                {
                    chart1.Series["Categories"].Points.AddXY("", oper.Value);
                    int index = chart1.Series["Categories"].Points.Count - 1;
                    chart1.Series["Categories"].Points[index].LegendText = (oper.Value / 100).ToString("0.00%");
                }
                
            }
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOutcome = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lbBalanceValue = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDot = new System.Windows.Forms.Button();
            this.pnlAddAmount = new System.Windows.Forms.Panel();
            this.toolTipInterface = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAddAcount = new System.Windows.Forms.Panel();
            this.pbAddAcc = new System.Windows.Forms.PictureBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.tbAccName = new System.Windows.Forms.TextBox();
            this.cbAddAccCurrency = new System.Windows.Forms.ComboBox();
            this.lbAddAccCurrency = new System.Windows.Forms.Label();
            this.pnlAddToCategory = new System.Windows.Forms.Panel();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.cbSelectAccount = new System.Windows.Forms.ComboBox();
            this.lbSelectAccount = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCategoryImg)).BeginInit();
            this.pnlAddAmount.SuspendLayout();
            this.pnlAddAcount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAcc)).BeginInit();
            this.pnlAddToCategory.SuspendLayout();
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
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnAddAccount);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.pnlBalance);
            this.mainPanel.Controls.Add(this.btnCar);
            this.mainPanel.Controls.Add(this.btnTransport);
            this.mainPanel.Controls.Add(this.btnGifts);
            this.mainPanel.Controls.Add(this.btnCalendar);
            this.mainPanel.Controls.Add(this.btnFood);
            this.mainPanel.Controls.Add(this.btnCommunication);
            this.mainPanel.Controls.Add(this.btnAdd);
            this.mainPanel.Controls.Add(this.btnTaxi);
            this.mainPanel.Controls.Add(this.btnCharge);
            this.mainPanel.Controls.Add(this.btnSport);
            this.mainPanel.Controls.Add(this.btnClothes);
            this.mainPanel.Controls.Add(this.btnHouse);
            this.mainPanel.Controls.Add(this.btnEatingOut);
            this.mainPanel.Controls.Add(this.btnEntertainment);
            this.mainPanel.Controls.Add(this.btnHealth);
            this.mainPanel.Location = new System.Drawing.Point(12, 75);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(322, 485);
            this.mainPanel.TabIndex = 15;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbOutcome);
            this.panel1.Location = new System.Drawing.Point(4, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 39);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "17000";
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
            // pnlBalance
            // 
            this.pnlBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBalance.BackgroundImage")));
            this.pnlBalance.Controls.Add(this.lbBalanceValue);
            this.pnlBalance.Controls.Add(this.lbIncome);
            this.pnlBalance.Location = new System.Drawing.Point(4, 307);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(314, 39);
            this.pnlBalance.TabIndex = 17;
            // 
            // lbBalanceValue
            // 
            this.lbBalanceValue.AutoSize = true;
            this.lbBalanceValue.BackColor = System.Drawing.Color.Transparent;
            this.lbBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbBalanceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBalanceValue.Location = new System.Drawing.Point(90, 9);
            this.lbBalanceValue.Name = "lbBalanceValue";
            this.lbBalanceValue.Size = new System.Drawing.Size(59, 20);
            this.lbBalanceValue.TabIndex = 1;
            this.lbBalanceValue.Text = "17000";
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
            this.btnCalendar.Location = new System.Drawing.Point(246, 3);
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
            this.MenuStrip.Size = new System.Drawing.Size(1160, 24);
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
            this.русскийToolStripMenuItem});
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
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(686, 391);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Categories";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(201, 184);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(5, 212);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(312, 35);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(721, 27);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 1, 14, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 14, 0, 0, 0, 0);
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
            this.pnlAddAmount.Location = new System.Drawing.Point(360, 186);
            this.pnlAddAmount.Name = "pnlAddAmount";
            this.pnlAddAmount.Size = new System.Drawing.Size(320, 251);
            this.pnlAddAmount.TabIndex = 36;
            this.pnlAddAmount.Visible = false;
            // 
            // pnlAddAcount
            // 
            this.pnlAddAcount.Controls.Add(this.pbAddAcc);
            this.pnlAddAcount.Controls.Add(this.lbAccountName);
            this.pnlAddAcount.Controls.Add(this.tbAccName);
            this.pnlAddAcount.Location = new System.Drawing.Point(721, 172);
            this.pnlAddAcount.Name = "pnlAddAcount";
            this.pnlAddAcount.Size = new System.Drawing.Size(329, 130);
            this.pnlAddAcount.TabIndex = 37;
            // 
            // pbAddAcc
            // 
            this.pbAddAcc.Location = new System.Drawing.Point(239, 14);
            this.pbAddAcc.Name = "pbAddAcc";
            this.pbAddAcc.Size = new System.Drawing.Size(75, 68);
            this.pbAddAcc.TabIndex = 33;
            this.pbAddAcc.TabStop = false;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccountName.ForeColor = System.Drawing.Color.Green;
            this.lbAccountName.Location = new System.Drawing.Point(3, 58);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(141, 24);
            this.lbAccountName.TabIndex = 20;
            this.lbAccountName.Text = "Account Name:";
            // 
            // tbAccName
            // 
            this.tbAccName.Location = new System.Drawing.Point(7, 93);
            this.tbAccName.Name = "tbAccName";
            this.tbAccName.Size = new System.Drawing.Size(307, 20);
            this.tbAccName.TabIndex = 0;
            // 
            // cbAddAccCurrency
            // 
            this.cbAddAccCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddAccCurrency.FormattingEnabled = true;
            this.cbAddAccCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAddAccCurrency.Location = new System.Drawing.Point(196, 120);
            this.cbAddAccCurrency.Name = "cbAddAccCurrency";
            this.cbAddAccCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbAddAccCurrency.TabIndex = 36;
            // 
            // lbAddAccCurrency
            // 
            this.lbAddAccCurrency.AutoSize = true;
            this.lbAddAccCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddAccCurrency.ForeColor = System.Drawing.Color.Chocolate;
            this.lbAddAccCurrency.Location = new System.Drawing.Point(3, 115);
            this.lbAddAccCurrency.Name = "lbAddAccCurrency";
            this.lbAddAccCurrency.Size = new System.Drawing.Size(101, 24);
            this.lbAddAccCurrency.TabIndex = 35;
            this.lbAddAccCurrency.Text = "Currency:";
            // 
            // pnlAddToCategory
            // 
            this.pnlAddToCategory.Controls.Add(this.cbSelectCategory);
            this.pnlAddToCategory.Controls.Add(this.cbAddAccCurrency);
            this.pnlAddToCategory.Controls.Add(this.cbSelectAccount);
            this.pnlAddToCategory.Controls.Add(this.lbSelectAccount);
            this.pnlAddToCategory.Controls.Add(this.lbAddAccCurrency);
            this.pnlAddToCategory.Controls.Add(this.pbSelectedCategoryImg);
            this.pnlAddToCategory.Controls.Add(this.lbAddToCategory);
            this.pnlAddToCategory.Location = new System.Drawing.Point(360, 27);
            this.pnlAddToCategory.Name = "pnlAddToCategory";
            this.pnlAddToCategory.Size = new System.Drawing.Size(329, 153);
            this.pnlAddToCategory.TabIndex = 38;
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
            this.cbSelectCategory.ValueMemberChanged += new System.EventHandler(this.cbSelectCategory_ValueMemberChanged);
            this.cbSelectCategory.SelectedValueChanged += new System.EventHandler(this.cbSelectCategory_SelectedValueChanged);
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
            // MoneFy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1160, 572);
            this.Controls.Add(this.pnlAddToCategory);
            this.Controls.Add(this.pnlAddAcount);
            this.Controls.Add(this.pnlAddAmount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MoneFy";
            this.Text = "MoneFy";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCategoryImg)).EndInit();
            this.pnlAddAmount.ResumeLayout(false);
            this.pnlAddAmount.PerformLayout();
            this.pnlAddAcount.ResumeLayout(false);
            this.pnlAddAcount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAcc)).EndInit();
            this.pnlAddToCategory.ResumeLayout(false);
            this.pnlAddToCategory.PerformLayout();
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lbBalanceValue;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTipCategory;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Panel pnlAddAmount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ToolTip toolTipInterface;
        private System.Windows.Forms.Panel pnlAddAcount;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox tbAccName;
        private System.Windows.Forms.Panel pnlAddToCategory;
        private System.Windows.Forms.ComboBox cbAddAccCurrency;
        private System.Windows.Forms.Label lbAddAccCurrency;
        private System.Windows.Forms.PictureBox pbAddAcc;
        private System.Windows.Forms.ComboBox cbSelectAccount;
        private System.Windows.Forms.Label lbSelectAccount;
        private System.Windows.Forms.ComboBox cbSelectCategory;
    }
}

