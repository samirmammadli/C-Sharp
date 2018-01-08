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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.mainPanel.Location = new System.Drawing.Point(12, 51);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(340, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Categories";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(463, 384);
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
            // MoneFy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1008, 500);
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
    }
}

