using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{

    enum Instruments
    {
        Pen,
        Rectangle,
        Circle,
        FilledRectangle,
        FilledCircle,
        Line
    }



    class WinPaint
    {
        public Point Start { get; set; }
        public Point Finish { get; set; }
        public Pen Pen { get; set; }
        public Brush Brush { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public float PenDepth { get; set; }
        public Instruments CurrentInstrument { get; set; }
        public bool IsDrawing { get; set; }
        public int BufferSize { get; private set; }
        public bool Filled { get; set; }
        private LinkedList<Image> UndoRedoBuffer { get; set; }
        private LinkedListNode<Image> currentPosition;

        public WinPaint(Image img, int buffersize = 20)
        {
            BufferSize = buffersize;
            UndoRedoBuffer = new LinkedList<Image>();
            AddToBuffer(img);
            ForeColor = Color.Black;
            BackColor = Color.White;
            PenDepth = 5;
            Pen = new Pen(ForeColor, PenDepth);
            Brush = new SolidBrush(BackColor);
            IsDrawing = false;
            Filled = false;
        }

        public void SetBufferSize(int size)
        {
            if (size > 0 && size < 20)
                BufferSize = size;
            else
                throw new ArgumentException("Wrong size!");
        }

        public void AddToBuffer(Image img)
        {
            UndoRedoBuffer.AddLast(img);
            currentPosition = UndoRedoBuffer.Last;
            if (UndoRedoBuffer.Count > BufferSize)
                UndoRedoBuffer.RemoveFirst();
        }

        public void Undo()
        {
            if (currentPosition.Previous != null)          
                currentPosition = currentPosition.Previous;
        }

        public void Redo()
        {
            if (currentPosition.Next != null)
                currentPosition = currentPosition.Next;
        }

        public Image GetCurrentImage()
        {
            return currentPosition.Value;
        }
    }
}
