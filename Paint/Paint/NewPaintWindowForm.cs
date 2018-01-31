﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class NewPaintWindowForm : Form
    {
        private Point start;
        private Point finish;
        private int SkipDrawing;
        private bool IsDrawing = false;
        private WinPaint paint;

        public NewPaintWindowForm()
        {
            InitializeComponent();
            start = new Point(0, 0);
            finish = new Point(150, 150);

            var tempImg = new Bitmap(1900, 1600);
            Brush brush = new SolidBrush(Color.White);
            using (Graphics g = Graphics.FromImage(tempImg))
            {
                g.FillRectangle(brush, 0, 0, tempImg.Width, tempImg.Height);
            }
            paint = new WinPaint(tempImg);
            pbDrawCurrent.Image = tempImg.Clone() as Bitmap;
            btnBackColor.BackColor = paint.BackColor;
            btnForeColor.BackColor = paint.ForeColor;
        }

        private void NewPaintWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Draw(Point s, Point f)
        {
            pbDrawCurrent.Image.Dispose();
            pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                Pen pen = new Pen(paint.ForeColor, paint.PenDepth);
                Brush brush = new SolidBrush(paint.BackColor);
                //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                //g.DrawLine(pen, start, finish);

                //g.DrawRectangle(pen, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                //g.FillRectangle(brush, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                //g.DrawEllipse(pen, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                //g.FillEllipse(brush, s.X, s.Y, f.X - s.X, f.Y - s.Y);
            }
        }

        private void DrawPen()
        {
            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                paint.Pen.DashStyle = DashStyle.Dot;
                g.DrawLine(paint.Pen, start, finish);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDrawing = true;
                start.X = e.X;
                start.Y = e.Y;
                finish = start;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDrawing = false;
                paint.AddToBuffer(pbDrawCurrent.Image.Clone() as Bitmap);
                GC.Collect();
            }
        }


        private void DrawFigures(MouseEventArgs e)
        {
           
            if (SkipDrawing == 0)
            {
                SkipDrawing++;
                finish.X = e.X;
                finish.Y = e.Y;

                Point tempStart = start;
                Point tempFinish = finish;

                if (start.X > finish.X)
                {
                    tempStart.X = finish.X;
                    tempFinish.X = start.X;
                }
                if (start.Y > finish.Y)
                {
                    tempStart.Y = finish.Y;
                    tempFinish.Y = start.Y;
                }
                if (paint.CurrentInstrument == Instruments.Pen)
                {

                }
                else
                    Draw(tempStart, tempFinish);
            }
            else
                SkipDrawing = 0;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsDrawing) return;
            if (paint.CurrentInstrument == Instruments.Rectangle)
                DrawFigures(e);
            else
                DrawPen();


        }

        private void NewPaintWindowForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control) return;
            if (e.KeyCode == Keys.Z)
                btnUndo_Click(this, null);
            else if (e.KeyCode == Keys.Y)
                btnRedo_Click(this, null);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
                paint.Undo();
                pbDrawCurrent.Image.Dispose();
                pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            paint.Redo();
            pbDrawCurrent.Image.Dispose();
            pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (colorDialog)
            {
                colorDialog.ShowDialog();
                btnForeColor.BackColor = colorDialog.Color;
                paint.ForeColor = colorDialog.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (colorDialog)
            {
                colorDialog.ShowDialog();
                btnBackColor.BackColor = colorDialog.Color;
                paint.BackColor = colorDialog.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            paint.PenDepth = (float)numericUpDown1.Value;
        }
    }
}
