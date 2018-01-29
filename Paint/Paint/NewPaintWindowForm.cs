using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private bool DrawingStarted = false;
        public NewPaintWindowForm()
        {
            InitializeComponent();
            start = new Point(0, 0);
            finish = new Point(150, 150);
            //Draw();
        }

        private void NewPaintWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }


        private void Swap()
        {
            if (start.X > finish.X)
            {
                int temp = start.X;
                start.X = finish.X;
                finish.X = temp;
            }
            if (start.Y > finish.Y)
            {
                int temp = start.Y;
                start.Y = finish.Y;
                finish.Y = temp;
            }
        }

        //private void Draw()
        //{
        //    if (pictureBox1.Image == null)
        //        pictureBox1.Image = new Bitmap(600, 600);
        //    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
        //    {
        //        var current = Color.Red;
        //        Pen pen = new Pen(Color.Blue, 5);
        //        Brush brush = new SolidBrush(current);
        //        //g.DrawLine(pen, start, finish);
        //        g.DrawRectangle(pen, start.X, start.Y, Math.Abs(finish.X - start.X), Math.Abs(finish.Y - start.Y));
        //        g.FillRectangle(brush, start.X, start.Y, Math.Abs(finish.X - start.X), Math.Abs(finish.Y - start.Y));
        //        pictureBox1.Invalidate();
        //    }
        //}

        private void Draw(Point s, Point f)
        {
            if (pictureBox1.Image == null)
                pictureBox1.Image = new Bitmap(600, 600);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                var current = Color.Red;
                Pen pen = new Pen(Color.Blue, 5);
                Brush brush = new SolidBrush(current);
                //g.DrawLine(pen, start, finish);
                g.DrawRectangle(pen, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                g.FillRectangle(brush, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                pictureBox1.Invalidate();
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
            DrawingStarted = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawingStarted)
            {
                              
                finish.X = e.X;
                finish.Y = e.Y;

                Point TempStart = start;
                Point TempFinish = finish;
                 
                if (start.X > finish.X )
                {
                    TempStart.X = finish.X;
                    TempFinish.X = start.X;
                }
                if (start.Y > finish.Y)
                {
                    TempStart.Y = finish.Y;
                    TempFinish.Y = start.Y;
                }

                pictureBox1.Image = null;
                Draw(TempStart, TempFinish);
            }
        }
    }
}
