﻿namespace Paint
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
            this.pbDrawCurrent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawCurrent
            // 
            this.pbDrawCurrent.BackColor = System.Drawing.Color.Transparent;
            this.pbDrawCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawCurrent.Location = new System.Drawing.Point(0, 0);
            this.pbDrawCurrent.Name = "pbDrawCurrent";
            this.pbDrawCurrent.Size = new System.Drawing.Size(987, 533);
            this.pbDrawCurrent.TabIndex = 0;
            this.pbDrawCurrent.TabStop = false;
            this.pbDrawCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbDrawCurrent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbDrawCurrent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // NewPaintWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(987, 533);
            this.Controls.Add(this.pbDrawCurrent);
            this.Name = "NewPaintWindowForm";
            this.Text = "NewPaintWindowForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPaintWindowForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawCurrent;
    }
}