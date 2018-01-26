namespace MovieStore
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.cbViewed = new System.Windows.Forms.ComboBox();
            this.lbViewed = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbMovieImage = new System.Windows.Forms.PictureBox();
            this.pnlAddEditRemove = new System.Windows.Forms.Panel();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).BeginInit();
            this.pnlAddEditRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15718F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbMovieImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAddEditRemove, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.03597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.96403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(620, 370);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnExitProgram);
            this.panel1.Controls.Add(this.cbViewed);
            this.panel1.Controls.Add(this.lbViewed);
            this.panel1.Controls.Add(this.tbYear);
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Controls.Add(this.tbType);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Controls.Add(this.tbGenre);
            this.panel1.Controls.Add(this.lbGenre);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(3, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 89);
            this.panel1.TabIndex = 2;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnExitProgram.FlatAppearance.BorderSize = 0;
            this.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgram.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitProgram.ForeColor = System.Drawing.Color.White;
            this.btnExitProgram.Location = new System.Drawing.Point(3, 63);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(612, 26);
            this.btnExitProgram.TabIndex = 7;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // cbViewed
            // 
            this.cbViewed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewed.FormattingEnabled = true;
            this.cbViewed.Location = new System.Drawing.Point(488, 31);
            this.cbViewed.Name = "cbViewed";
            this.cbViewed.Size = new System.Drawing.Size(100, 21);
            this.cbViewed.TabIndex = 10;
            this.cbViewed.SelectedIndexChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lbViewed
            // 
            this.lbViewed.AutoSize = true;
            this.lbViewed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbViewed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbViewed.Location = new System.Drawing.Point(484, 10);
            this.lbViewed.Name = "lbViewed";
            this.lbViewed.Size = new System.Drawing.Size(72, 19);
            this.lbViewed.TabIndex = 9;
            this.lbViewed.Text = "Viewed:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(368, 32);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 8;
            this.tbYear.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbYear.Location = new System.Drawing.Point(364, 10);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(49, 19);
            this.lbYear.TabIndex = 7;
            this.lbYear.Text = "Year:";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(248, 32);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 20);
            this.tbType.TabIndex = 6;
            this.tbType.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbType.Location = new System.Drawing.Point(244, 10);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(50, 19);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(128, 32);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 4;
            this.tbGenre.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbGenre.Location = new System.Drawing.Point(124, 10);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(61, 19);
            this.lbGenre.TabIndex = 3;
            this.lbGenre.Text = "Genre:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(8, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbTitle.Location = new System.Drawing.Point(4, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(42, 19);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // pbMovieImage
            // 
            this.pbMovieImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMovieImage.Location = new System.Drawing.Point(629, 3);
            this.pbMovieImage.Name = "pbMovieImage";
            this.pbMovieImage.Size = new System.Drawing.Size(252, 370);
            this.pbMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovieImage.TabIndex = 3;
            this.pbMovieImage.TabStop = false;
            // 
            // pnlAddEditRemove
            // 
            this.pnlAddEditRemove.Controls.Add(this.btnRemoveSelected);
            this.pnlAddEditRemove.Controls.Add(this.btnEditSelected);
            this.pnlAddEditRemove.Controls.Add(this.btnAddNew);
            this.pnlAddEditRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddEditRemove.Location = new System.Drawing.Point(629, 379);
            this.pnlAddEditRemove.Name = "pnlAddEditRemove";
            this.pnlAddEditRemove.Size = new System.Drawing.Size(252, 89);
            this.pnlAddEditRemove.TabIndex = 4;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnRemoveSelected.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(3, 64);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(246, 26);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnEditSelected.FlatAppearance.BorderSize = 0;
            this.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSelected.ForeColor = System.Drawing.Color.White;
            this.btnEditSelected.Location = new System.Drawing.Point(3, 32);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(246, 26);
            this.btnEditSelected.TabIndex = 5;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = false;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(3, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(246, 26);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(900, 510);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).EndInit();
            this.pnlAddEditRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cbViewed;
        private System.Windows.Forms.Label lbViewed;
        private System.Windows.Forms.PictureBox pbMovieImage;
        private System.Windows.Forms.Panel pnlAddEditRemove;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnExitProgram;
    }
}

