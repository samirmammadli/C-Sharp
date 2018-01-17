namespace MoneFeWinForms
{
    partial class Choose_Period
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Period));
            this.btnYear = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.tbChooseDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYear.Location = new System.Drawing.Point(80, 54);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(111, 23);
            this.btnYear.TabIndex = 0;
            this.btnYear.Text = "Year";
            this.btnYear.UseVisualStyleBackColor = false;
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMonth.Location = new System.Drawing.Point(80, 83);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(111, 23);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = false;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.LimeGreen;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWeek.Location = new System.Drawing.Point(80, 112);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(111, 23);
            this.btnWeek.TabIndex = 2;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = false;
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDay.Location = new System.Drawing.Point(80, 141);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(111, 23);
            this.btnDay.TabIndex = 3;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = false;
            // 
            // tbChooseDate
            // 
            this.tbChooseDate.BackColor = System.Drawing.Color.MintCream;
            this.tbChooseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChooseDate.Enabled = false;
            this.tbChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChooseDate.ForeColor = System.Drawing.Color.Maroon;
            this.tbChooseDate.Location = new System.Drawing.Point(49, 12);
            this.tbChooseDate.Name = "tbChooseDate";
            this.tbChooseDate.Size = new System.Drawing.Size(175, 19);
            this.tbChooseDate.TabIndex = 4;
            this.tbChooseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Choose_Period
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(273, 198);
            this.Controls.Add(this.tbChooseDate);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Choose_Period";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.TextBox tbChooseDate;
    }
}