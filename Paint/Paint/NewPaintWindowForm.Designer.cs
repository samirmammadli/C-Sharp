namespace Paint
{
    partial class NewPaintWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPaintWindowForm));
            this.pbDrawCurrent = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lbDepth = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawCurrent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawCurrent
            // 
            this.pbDrawCurrent.BackColor = System.Drawing.Color.Transparent;
            this.pbDrawCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawCurrent.Location = new System.Drawing.Point(3, 76);
            this.pbDrawCurrent.Name = "pbDrawCurrent";
            this.pbDrawCurrent.Size = new System.Drawing.Size(981, 454);
            this.pbDrawCurrent.TabIndex = 0;
            this.pbDrawCurrent.TabStop = false;
            this.pbDrawCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbDrawCurrent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbDrawCurrent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pbDrawCurrent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 533);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnBackColor);
            this.panel1.Controls.Add(this.btnForeColor);
            this.panel1.Controls.Add(this.lbDepth);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 67);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(238, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Transparent;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(49, 9);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(40, 40);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(3, 9);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(40, 40);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lbDepth
            // 
            this.lbDepth.AutoSize = true;
            this.lbDepth.Location = new System.Drawing.Point(235, 9);
            this.lbDepth.Name = "lbDepth";
            this.lbDepth.Size = new System.Drawing.Size(36, 13);
            this.lbDepth.TabIndex = 4;
            this.lbDepth.Text = "Depth";
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnForeColor.Location = new System.Drawing.Point(351, 9);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(44, 43);
            this.btnForeColor.TabIndex = 5;
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.Aqua;
            this.btnBackColor.Location = new System.Drawing.Point(401, 9);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(44, 43);
            this.btnBackColor.TabIndex = 6;
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // NewPaintWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(987, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "NewPaintWindowForm";
            this.Text = "NewPaintWindowForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPaintWindowForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPaintWindowForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawCurrent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawCurrent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label lbDepth;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnBackColor;
    }
}