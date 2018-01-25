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
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(37, 16);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Title:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(12, 35);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 4;
            this.lbGenre.Text = "Genre:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(12, 63);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type:";
            // 
            // lbRuntime
            // 
            this.lbRuntime.AutoSize = true;
            this.lbRuntime.Location = new System.Drawing.Point(12, 92);
            this.lbRuntime.Name = "lbRuntime";
            this.lbRuntime.Size = new System.Drawing.Size(49, 13);
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
            this.lbYear.Location = new System.Drawing.Point(12, 118);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(32, 13);
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
            this.pbImage.Size = new System.Drawing.Size(196, 185);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(214, 170);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(89, 23);
            this.btnLoadImage.TabIndex = 13;
            this.btnLoadImage.Text = "Upload Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // cbViewed
            // 
            this.cbViewed.AutoSize = true;
            this.cbViewed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbViewed.Location = new System.Drawing.Point(228, 120);
            this.cbViewed.Name = "cbViewed";
            this.cbViewed.Size = new System.Drawing.Size(61, 17);
            this.cbViewed.TabIndex = 14;
            this.cbViewed.Text = "Viewed";
            this.cbViewed.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search by Title";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 202);
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
            this.Name = "AddEditMovie";
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
    }
}