using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class WinPaint
    {
        public Point Start { get; set; }
        public Point Finish { get; set; }
        public int SkipDrawingCycle { get; set; }
        public bool IsDrawing { get; set; }
        public int BufferSize { get; set; }
        private LinkedList<Image> UndoRedoBuffer { get; set; }
        private LinkedListNode<Image> currentPosition;

        public WinPaint(Image img, int buffersize = 20)
        {
            BufferSize = buffersize;
            UndoRedoBuffer = new LinkedList<Image>();
            AddToBuffer(img);

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
