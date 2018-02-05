using System;
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
        private WinPaint paint;
        public NewPaintWindowForm()
        {
            InitializeComponent();

            var tempImg = new Bitmap(900, 600);
            Brush brush = new SolidBrush(Color.White);
            using (Graphics g = Graphics.FromImage(tempImg))
            {
                g.FillRectangle(brush, 0, 0, tempImg.Width, tempImg.Height);
            }
            paint = new WinPaint(tempImg);
            pbDrawCurrent.Image = tempImg.Clone() as Bitmap;
            btnBackColor.BackColor = paint.BackColor;
            btnForeColor.BackColor = paint.ForeColor;
            paint.CurrentInstrument = Instruments.Pen;
        }

        private void NewPaintWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
            else if (result == DialogResult.Yes)
            {
                using (saveFileDialog1)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        paint.GetCurrentImage().Save(saveFileDialog1.FileName);
                    }

                }
            }
        }

        private void DrawFigures(Point s, Point f)
        {
            pbDrawCurrent.Image.Dispose();
            pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                if (paint.CurrentInstrument == Instruments.Rectangle)
                {
                    g.DrawRectangle(paint.Pen, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                    if (paint.Filled) g.FillRectangle(paint.Brush, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                }
                else
                {
                    g.DrawEllipse(paint.Pen, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                    if (paint.Filled) g.FillEllipse(paint.Brush, s.X, s.Y, f.X - s.X, f.Y - s.Y);
                }
            }
        }

        private void DrawPen(MouseEventArgs e)
        {
            paint.Start = paint.Finish;
            paint.Finish = e.Location;
            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                g.DrawLine(paint.Pen, paint.Start, paint.Finish);
                pbDrawCurrent.Invalidate();
            }
        }

        private void DrawLine(Point s, Point f)
        {
            pbDrawCurrent.Image.Dispose();
            pbDrawCurrent.Image = paint.GetCurrentImage().Clone() as Bitmap;

            using (Graphics g = Graphics.FromImage(pbDrawCurrent.Image))
            {
                g.DrawLine(paint.Pen, s, f);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint.IsDrawing = true;
                paint.Start = e.Location;
                paint.Finish = paint.Start;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint.IsDrawing = false;
                paint.AddToBuffer(pbDrawCurrent.Image.Clone() as Bitmap);
                GC.Collect();
            }
        }


        private void SetFiguresCoords(MouseEventArgs e)
        {
            paint.Finish = e.Location;

            Point tempStart = paint.Start;
            Point tempFinish = paint.Finish;

            if (paint.Start.X > paint.Finish.X)
            {
                tempStart.X = paint.Finish.X;
                tempFinish.X = paint.Start.X;
            }
            if (paint.Start.Y > paint.Finish.Y)
            {
                tempStart.Y = paint.Finish.Y;
                tempFinish.Y = paint.Start.Y;
            }
            DrawFigures(tempStart, tempFinish);
        }

        


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!paint.IsDrawing) return;
            if (paint.CurrentInstrument == Instruments.Pen)
                DrawPen(e);
            else if (paint.CurrentInstrument == Instruments.Line)
                DrawLine(paint.Start, e.Location);
            else
                SetFiguresCoords(e);

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
                paint.Pen.Color = paint.ForeColor;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (colorDialog)
            {
                colorDialog.ShowDialog();
                btnBackColor.BackColor = colorDialog.Color;
                paint.BackColor = colorDialog.Color;
                paint.Brush.Dispose();
                paint.Brush = new SolidBrush(paint.BackColor);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            paint.PenDepth = (float)numericUpDown1.Value;
            paint.Pen.Width = paint.PenDepth;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            paint.CurrentInstrument = Instruments.Pen;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            paint.CurrentInstrument = Instruments.Rectangle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            paint.CurrentInstrument = Instruments.Circle;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            paint.CurrentInstrument = Instruments.Line;
        }

        private void cbDrawFilled_CheckedChanged(object sender, EventArgs e)
        {
            paint.Filled = cbDrawFilled.Checked;
        }
    }
}
