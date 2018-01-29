using System;
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
        Image Savedimg;
        private bool DrawingStarted = false;
       
        public NewPaintWindowForm()
        {
            InitializeComponent();
            start = new Point(0, 0);
            finish = new Point(150, 150);

            pbDrawCurrent.Image = new Bitmap(600, 600);
            Savedimg = new Bitmap(600, 600);
            Brush brush = new SolidBrush(Color.White);
            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                g.FillRectangle(brush, 0, 0, pbDrawCurrent.Image.Width, pbDrawCurrent.Image.Height);
            }

            //pbDrawCurrent.BringToFront();
            //pbMainCanvas.SendToBack();

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


        private void Draw(Point s, Point f)
        {
            if (pbDrawCurrent.Image == null)
            {
                pbDrawCurrent.Image = new Bitmap(Savedimg);//new Bitmap(600, 600);
            }
                

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                var current = Color.Red;
                Pen pen = new Pen(Color.Blue, 5);
                Brush brush = new SolidBrush(current);
                //g.DrawLine(pen, start, finish);
                g.DrawRectangle(pen, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                //g.FillRectangle(brush, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                //g.DrawEllipse(pen, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                //g.FillEllipse(brush, s.X, s.Y, Math.Abs(f.X - s.X), Math.Abs(f.Y - s.Y));
                pbDrawCurrent.Invalidate();
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
                //using (Graphics g1 = Graphics.FromImage(pbDrawCurrent.Image))
                //{
                //    g1.DrawImage(pbMainCanvas.Image, new Point(0, 0));

                //}
                //pbDrawCurrent.CreateGraphics().DrawImage(Savedimg, new Point(0, 0));
                //Savedimg = new Bitmap(pbDrawCurrent.Image);
                pbDrawCurrent.DrawToBitmap(Savedimg as Bitmap, pbDrawCurrent.Bounds);
            }
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

                pbDrawCurrent.Image = null;//new Bitmap(Savedimg);
                Draw(TempStart, TempFinish);
            }
        }
    }
}
