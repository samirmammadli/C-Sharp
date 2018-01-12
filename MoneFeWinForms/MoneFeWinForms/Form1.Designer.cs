using System;

namespace MoneFeWinForms
{
    partial class MoneFy
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

        private void LoadLang()
        {
            //Categories
            toolTipCategory.SetToolTip(this.btnCar, Monefy.Categories["cars"]);
            toolTipCategory.SetToolTip(this.btnClothes, Monefy.Categories["clothes"]);
            toolTipCategory.SetToolTip(this.btnCommunication, Monefy.Categories["communications"]);
            toolTipCategory.SetToolTip(this.btnEatingOut, Monefy.Categories["eating_out"]);
            toolTipCategory.SetToolTip(this.btnEntertainment, Monefy.Categories["entertainment"]);
            toolTipCategory.SetToolTip(this.btnFood, Monefy.Categories["food"]);
            toolTipCategory.SetToolTip(this.btnGifts, Monefy.Categories["gifts"]);
            toolTipCategory.SetToolTip(this.btnHealth, Monefy.Categories["health"]);
            toolTipCategory.SetToolTip(this.btnHouse, Monefy.Categories["house"]);
            toolTipCategory.SetToolTip(this.btnSport, Monefy.Categories["sports"]);
            toolTipCategory.SetToolTip(this.btnTaxi, Monefy.Categories["taxi"]);
            toolTipCategory.SetToolTip(this.btnTransport, Monefy.Categories["transport"]);
            //Interface
            this.toolTipCategory.ToolTipTitle = Monefy.Interface["category"] + ":";
            this.languageToolStripMenuItem.Text = Monefy.Interface["language"];
            this.englishToolStripMenuItem.Text = Monefy.Interface["lang_english"];
            this.русскийToolStripMenuItem.Text = Monefy.Interface["lang_russian"];
            this.exitToolStripMenuItem.Text = Monefy.Interface["file"];
            this.exitToolStripMenuItem1.Text = Monefy.Interface["exit"];
            this.lbIncome.Text = Monefy.Interface["income"] + ":";
            this.lbOutcome.Text = Monefy.Interface["outcome"] + ":";
            this.btnAddCategory.Text = Monefy.Interface["add"];
        }

        private void LoadCategoriesChart()
        {
            Random rnd = new Random();
            foreach (var item in Monefy.Categories)
            {
                int a = rnd.Next(1, 150);
                int index = chart1.Series["Categories"].Points.Count;
                chart1.Series["Categories"].Points.AddXY("", a);
                chart1.Series["Categories"].Points[index].LegendText = item.Value + $" {(a / 150f).ToString("0.00%")}";
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOutcome = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lbBalanceValue = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipCategory = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tnAmount = new System.Windows.Forms.TextBox();
            this.lbAddToCategory = new System.Windows.Forms.Label();
            this.lbAddedCategory = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pbSelectedCategoryImg = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCategoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(240, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 77);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.Transparent;
            this.btnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharge.ForeColor = System.Drawing.Color.Transparent;
            this.btnCharge.Image = ((System.Drawing.Image)(resources.GetObject("btnCharge.Image")));
            this.btnCharge.Location = new System.Drawing.Point(3, 306);
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
            this.btnClothes.Location = new System.Drawing.Point(83, 3);
            this.btnClothes.Name = "btnClothes";
            this.btnClothes.Size = new System.Drawing.Size(74, 64);
            this.btnClothes.TabIndex = 2;
            this.btnClothes.UseVisualStyleBackColor = false;
            // 
            // btnCommunication
            // 
            this.btnCommunication.BackColor = System.Drawing.Color.Transparent;
            this.btnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunication.ForeColor = System.Drawing.Color.Transparent;
            this.btnCommunication.Image = ((System.Drawing.Image)(resources.GetObject("btnCommunication.Image")));
            this.btnCommunication.Location = new System.Drawing.Point(163, 73);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(74, 64);
            this.btnCommunication.TabIndex = 7;
            this.btnCommunication.UseVisualStyleBackColor = false;
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCar.Image")));
            this.btnCar.Location = new System.Drawing.Point(3, 3);
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
            this.btnEntertainment.Location = new System.Drawing.Point(240, 3);
            this.btnEntertainment.Name = "btnEntertainment";
            this.btnEntertainment.Size = new System.Drawing.Size(74, 64);
            this.btnEntertainment.TabIndex = 4;
            this.btnEntertainment.UseVisualStyleBackColor = false;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.Transparent;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.Location = new System.Drawing.Point(6, 73);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(74, 64);
            this.btnFood.TabIndex = 5;
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // btnGifts
            // 
            this.btnGifts.BackColor = System.Drawing.Color.Transparent;
            this.btnGifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGifts.ForeColor = System.Drawing.Color.Transparent;
            this.btnGifts.Image = ((System.Drawing.Image)(resources.GetObject("btnGifts.Image")));
            this.btnGifts.Location = new System.Drawing.Point(83, 73);
            this.btnGifts.Name = "btnGifts";
            this.btnGifts.Size = new System.Drawing.Size(74, 64);
            this.btnGifts.TabIndex = 6;
            this.btnGifts.UseVisualStyleBackColor = false;
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.Transparent;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.ForeColor = System.Drawing.Color.Transparent;
            this.btnHealth.Image = ((System.Drawing.Image)(resources.GetObject("btnHealth.Image")));
            this.btnHealth.Location = new System.Drawing.Point(243, 73);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(74, 64);
            this.btnHealth.TabIndex = 8;
            this.btnHealth.UseVisualStyleBackColor = false;
            // 
            // btnEatingOut
            // 
            this.btnEatingOut.BackColor = System.Drawing.Color.Transparent;
            this.btnEatingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatingOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnEatingOut.Image = ((System.Drawing.Image)(resources.GetObject("btnEatingOut.Image")));
            this.btnEatingOut.Location = new System.Drawing.Point(163, 3);
            this.btnEatingOut.Name = "btnEatingOut";
            this.btnEatingOut.Size = new System.Drawing.Size(74, 64);
            this.btnEatingOut.TabIndex = 3;
            this.btnEatingOut.UseVisualStyleBackColor = false;
            // 
            // btnHouse
            // 
            this.btnHouse.BackColor = System.Drawing.Color.Transparent;
            this.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouse.ForeColor = System.Drawing.Color.Transparent;
            this.btnHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnHouse.Image")));
            this.btnHouse.Location = new System.Drawing.Point(3, 143);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(74, 64);
            this.btnHouse.TabIndex = 9;
            this.btnHouse.UseVisualStyleBackColor = false;
            // 
            // btnTransport
            // 
            this.btnTransport.BackColor = System.Drawing.Color.Transparent;
            this.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransport.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransport.Image = ((System.Drawing.Image)(resources.GetObject("btnTransport.Image")));
            this.btnTransport.Location = new System.Drawing.Point(243, 143);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(74, 64);
            this.btnTransport.TabIndex = 12;
            this.btnTransport.UseVisualStyleBackColor = false;
            // 
            // btnTaxi
            // 
            this.btnTaxi.BackColor = System.Drawing.Color.Transparent;
            this.btnTaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxi.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaxi.Image")));
            this.btnTaxi.Location = new System.Drawing.Point(163, 143);
            this.btnTaxi.Name = "btnTaxi";
            this.btnTaxi.Size = new System.Drawing.Size(74, 64);
            this.btnTaxi.TabIndex = 11;
            this.btnTaxi.UseVisualStyleBackColor = false;
            // 
            // btnSport
            // 
            this.btnSport.BackColor = System.Drawing.Color.Transparent;
            this.btnSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSport.ForeColor = System.Drawing.Color.Transparent;
            this.btnSport.Image = ((System.Drawing.Image)(resources.GetObject("btnSport.Image")));
            this.btnSport.Location = new System.Drawing.Point(83, 143);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(74, 64);
            this.btnSport.TabIndex = 10;
            this.btnSport.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.pnlBalance);
            this.mainPanel.Controls.Add(this.btnCar);
            this.mainPanel.Controls.Add(this.btnTransport);
            this.mainPanel.Controls.Add(this.btnGifts);
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
            this.mainPanel.Location = new System.Drawing.Point(12, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(322, 386);
            this.mainPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbOutcome);
            this.panel1.Location = new System.Drawing.Point(3, 258);
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
            this.pnlBalance.Location = new System.Drawing.Point(3, 213);
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
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1008, 24);
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
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(964, 461);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Categories";
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(32, 10);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(852, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 64);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(368, 398);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(312, 35);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tnAmount
            // 
            this.tnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnAmount.Location = new System.Drawing.Point(368, 190);
            this.tnAmount.Name = "tnAmount";
            this.tnAmount.Size = new System.Drawing.Size(312, 26);
            this.tnAmount.TabIndex = 1;
            // 
            // lbAddToCategory
            // 
            this.lbAddToCategory.AutoSize = true;
            this.lbAddToCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddToCategory.ForeColor = System.Drawing.Color.Green;
            this.lbAddToCategory.Location = new System.Drawing.Point(365, 129);
            this.lbAddToCategory.Name = "lbAddToCategory";
            this.lbAddToCategory.Size = new System.Drawing.Size(0, 24);
            this.lbAddToCategory.TabIndex = 19;
            // 
            // lbAddedCategory
            // 
            this.lbAddedCategory.AutoSize = true;
            this.lbAddedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddedCategory.ForeColor = System.Drawing.Color.Brown;
            this.lbAddedCategory.Location = new System.Drawing.Point(365, 153);
            this.lbAddedCategory.Name = "lbAddedCategory";
            this.lbAddedCategory.Size = new System.Drawing.Size(0, 24);
            this.lbAddedCategory.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(368, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(474, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(580, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.DarkGreen;
            this.button5.Location = new System.Drawing.Point(368, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.TabIndex = 24;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.DarkGreen;
            this.button6.Location = new System.Drawing.Point(474, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.TabIndex = 28;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.DarkGreen;
            this.button7.Location = new System.Drawing.Point(368, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.TabIndex = 27;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.DarkGreen;
            this.button8.Location = new System.Drawing.Point(580, 267);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 35);
            this.button8.TabIndex = 26;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.DarkGreen;
            this.button9.Location = new System.Drawing.Point(474, 267);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 35);
            this.button9.TabIndex = 25;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.DarkGreen;
            this.button12.Location = new System.Drawing.Point(368, 357);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 35);
            this.button12.TabIndex = 30;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.Color.DarkGreen;
            this.button13.Location = new System.Drawing.Point(580, 312);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 35);
            this.button13.TabIndex = 29;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.DarkGreen;
            this.button10.Location = new System.Drawing.Point(474, 357);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(206, 36);
            this.button10.TabIndex = 31;
            this.button10.Text = "<-";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // pbSelectedCategoryImg
            // 
            this.pbSelectedCategoryImg.Location = new System.Drawing.Point(605, 129);
            this.pbSelectedCategoryImg.Name = "pbSelectedCategoryImg";
            this.pbSelectedCategoryImg.Size = new System.Drawing.Size(75, 55);
            this.pbSelectedCategoryImg.TabIndex = 32;
            this.pbSelectedCategoryImg.TabStop = false;
            // 
            // MoneFy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1008, 483);
            this.Controls.Add(this.pbSelectedCategoryImg);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbAddedCategory);
            this.Controls.Add(this.lbAddToCategory);
            this.Controls.Add(this.tnAmount);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tnAmount;
        private System.Windows.Forms.Label lbAddToCategory;
        private System.Windows.Forms.Label lbAddedCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pbSelectedCategoryImg;
    }
}

