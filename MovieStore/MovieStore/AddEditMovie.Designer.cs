namespace MovieStore
{
    partial class AddEditMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMovie));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbRuntime = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.cbViewed = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.ofdLoadImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.btnSave.Location = new System.Drawing.Point(12, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.btnCancel.Location = new System.Drawing.Point(93, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(107, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(182, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 16);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Title:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbGenre.Location = new System.Drawing.Point(12, 35);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(52, 16);
            this.lbGenre.TabIndex = 4;
            this.lbGenre.Text = "Genre:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbType.Location = new System.Drawing.Point(12, 63);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(43, 16);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type:";
            // 
            // lbRuntime
            // 
            this.lbRuntime.AutoSize = true;
            this.lbRuntime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbRuntime.Location = new System.Drawing.Point(12, 92);
            this.lbRuntime.Name = "lbRuntime";
            this.lbRuntime.Size = new System.Drawing.Size(64, 16);
            this.lbRuntime.TabIndex = 6;
            this.lbRuntime.Text = "Runtime:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(107, 35);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(182, 20);
            this.tbGenre.TabIndex = 7;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(107, 63);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(182, 20);
            this.tbType.TabIndex = 8;
            // 
            // tbRuntime
            // 
            this.tbRuntime.Location = new System.Drawing.Point(107, 92);
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.Size = new System.Drawing.Size(182, 20);
            this.tbRuntime.TabIndex = 9;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(107, 118);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(115, 20);
            this.tbYear.TabIndex = 11;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.lbYear.Location = new System.Drawing.Point(12, 118);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(42, 16);
            this.lbYear.TabIndex = 10;
            this.lbYear.Text = "Year:";
            // 
            // pbImage
            // 
            this.pbImage.ErrorImage = null;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(306, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(207, 232);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnLoadImage.FlatAppearance.BorderSize = 0;
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.btnLoadImage.Location = new System.Drawing.Point(413, 243);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 23);
            this.btnLoadImage.TabIndex = 13;
            this.btnLoadImage.Text = "Upload Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // cbViewed
            // 
            this.cbViewed.AutoSize = true;
            this.cbViewed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbViewed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.cbViewed.Location = new System.Drawing.Point(228, 120);
            this.cbViewed.Name = "cbViewed";
            this.cbViewed.Size = new System.Drawing.Size(75, 20);
            this.cbViewed.TabIndex = 14;
            this.cbViewed.Text = "Viewed";
            this.cbViewed.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.btnSearch.Location = new System.Drawing.Point(122, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search by Title";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnDeleteImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(102)))));
            this.btnDeleteImage.Location = new System.Drawing.Point(306, 243);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteImage.TabIndex = 16;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // ofdLoadImage
            // 
            this.ofdLoadImage.Filter = "Image Files(*.BMP;*.JPG;*.JPEG)|*.BMP;*.JPG;*.JPEG";
            // 
            // AddEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(518, 271);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbViewed);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.tbRuntime);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.lbRuntime);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEditMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditMovie";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbRuntime;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbRuntime;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.CheckBox cbViewed;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.OpenFileDialog ofdLoadImage;
    }
}