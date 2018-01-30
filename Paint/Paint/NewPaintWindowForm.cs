﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int FrameSkip;
        Image Savedimg;
        private bool DrawingStarted = false;
       
        public NewPaintWindowForm()
        {
            InitializeComponent();
            start = new Point(0, 0);
            finish = new Point(150, 150);

            Savedimg = new Bitmap(1900, 1600);
            Brush brush = new SolidBrush(Color.White);
            using (Graphics g = Graphics.FromImage(Savedimg))
            {
                g.FillRectangle(brush, 0, 0, Savedimg.Width, Savedimg.Height);
            }
            pbDrawCurrent.Image = Savedimg.Clone() as Bitmap;
        }

        private void NewPaintWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Draw(Point s, Point f)
        {

            pbDrawCurrent.Image = Savedimg.Clone() as Bitmap;

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                var current = Color.Red;
                Pen pen = new Pen(Color.Blue, 5);
                Brush brush = new SolidBrush(current);
                //g.DrawLine(pen, start, finish);
                //g.DrawRectangle(pen, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                //g.FillRectangle(brush, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                g.DrawEllipse(pen, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                g.FillEllipse(brush, s.X, s.Y, f.X - s.X, f.Y - s.Y);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawingStarted = true;
                start.X = e.X;
                start.Y = e.Y;
                finish = start;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawingStarted = false;
                Savedimg = pbDrawCurrent.Image.Clone() as Bitmap;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawingStarted)
            {
                if (FrameSkip == 0)
                {
                    FrameSkip++;
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
                    Draw(tempStart, tempFinish);
                }
                else
                    FrameSkip = 0;
                              
                
            }
        }
    }
}
