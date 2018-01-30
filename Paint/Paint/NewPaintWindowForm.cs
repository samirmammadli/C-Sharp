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
        }

        private void NewPaintWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Draw(Point s, Point f)
        {

            pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                var current = Color.Red;
                Pen pen = new Pen(Color.Blue, 5);
                Brush brush = new SolidBrush(current);
                //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
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
                    Draw(tempStart, tempFinish);
                }
                else
                    SkipDrawing = 0;
                              
                
            }
        }

        private void NewPaintWindowForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Undo();
                pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;
            }
            catch (Exception)
            {

                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Redo();
                pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;
            }
            catch (Exception)
            {

               
            }
            
        }
    }
}
