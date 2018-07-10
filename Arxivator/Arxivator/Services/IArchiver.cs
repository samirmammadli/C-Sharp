using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arxivator.Services
{
    public delegate void CompressionDone(bool isDone, string message);
    public delegate void ProgressChanged(int index, int step = 1);
    public delegate void ThreadsCountChanged(int count);

    public interface IArchiver
    {
        event CompressionDone CompressionDoneEventHandler;
        event ThreadsCountChanged ThreadsChanged;
        event ProgressChanged ProgressValueChanged;
        void Compress(string file, int threadsCount);
        void Decompress(string filename);
    }
}
