using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows;
using System.Collections.ObjectModel;

namespace Arxivator
{

    public delegate void CompressionDoneDelegate(bool isDone, string message);

    public interface IArchiver
    {
        event CompressionDoneDelegate CompressionDoneEventHandler;
        void Compress(string file, int threadsCount, ArchiverParam parameters);
        void Decompress(string filename);
    }

    public class ArchiverParam
    {
        public ArchiverParam(ObservableCollection<ProgressBarValues> progress)
        {
            Progress = progress;
        }

        public ObservableCollection<ProgressBarValues> Progress { get; set; }
    }

    public static class ByteArraySplitter
    {
        public static List<int> SearchBytePattern(this byte[] bytes, byte[] pattern)
        {
            List<int> positions = new List<int>();
            int patternLength = pattern.Length;
            int totalLength = bytes.Length;
            byte firstMatchByte = pattern[0];
            for (int i = 0; i < totalLength; i++)
            {
                if (firstMatchByte == bytes[i] && totalLength - i >= patternLength) 
                {
                    byte[] match = new byte[patternLength];
                    Array.Copy(bytes, i, match, 0, patternLength);
                    if (match.SequenceEqual<byte>(pattern))
                    {
                        positions.Add(i);
                        i += patternLength - 1;
                    }
                }
            }
            return positions;
        }
    }

    class GzipArchiver : IArchiver
    {
        public event CompressionDoneDelegate CompressionDoneEventHandler;

        public List<byte[]> ParseBytes(byte[] bytes, int count)
        {
            var list = new List<byte[]>();
            var chunkSize = bytes.Length / count;
            if (chunkSize < 2 || count == 1)
            {
                list.Add(bytes);
                return list;
            }
            var rest = bytes.Length - chunkSize * (count - 1);
            for (int i = 0; i < count - 1; i++)
            {
                var chunk = new byte[chunkSize];
                Buffer.BlockCopy(bytes, chunkSize * i, chunk, 0, chunkSize);
                list.Add(chunk);
            }

            var chunk1 = new byte[rest];
            Buffer.BlockCopy(bytes, chunkSize * (count - 1), chunk1, 0, rest);
            list.Add(chunk1);

            return list;
        }

        public void Compress(string file, int threadsCount, ArchiverParam parameters)
        {
            var fileBytes = File.ReadAllBytes(file);
            var inputChunks = ParseBytes(fileBytes, threadsCount);
            var threads = new List<Task<byte[]>>();
            const string extension = ".gz";
            for (var i = 0; i < parameters.Progress.Count; i++)
            {
                parameters.Progress[i].BarValue = 0;
            }
            var start = DateTime.Now.Ticks;
            for (var i = 0; i < inputChunks.Count; i++)
            {
                var iter = i;
                threads.Add(new Task<byte[]>(() =>
                {
                    using (var mStream = new MemoryStream())
                    {
                        using (var gZipStream = new GZipStream(mStream, CompressionMode.Compress))
                        {
                            var lenght = inputChunks[iter].Length / 100;
                            if (lenght < 1)
                            {
                                gZipStream.Write(inputChunks[iter], 0, inputChunks[iter].Length);
                                parameters.Progress[iter].BarValue = 100;
                            }
                            else
                            {
                                for (var j = 0; j < 100; j++)
                                {
                                    gZipStream.Write(inputChunks[iter], j * lenght, lenght);
                                    parameters.Progress[iter].BarValue++;
                                }
                                gZipStream.Write(inputChunks[iter], lenght * 100, inputChunks[iter].Length - lenght * 100);
                            }
                        }
                        return mStream.ToArray();
                    }
                }));
            }
            threads.ForEach(x => x.Start());
            WhenCompressThreadsDone(file + extension, threads, start);
        }

        public void WhenCompressThreadsDone(string filename, List<Task<byte[]>> threads, long ticks)
        {

                Task.WhenAll(threads).ContinueWith(param =>
                {
                    try
                    {
                        var list = new byte[threads.Sum(x => x.Result.Length)];
                        var offset = 0;
                        threads.ForEach(x => { Buffer.BlockCopy(x.Result, 0, list, offset, x.Result.Length); offset += x.Result.Length; });
                        File.WriteAllBytes(filename, list);
                        CompressionDoneEventHandler?.Invoke(true, $"Success!\nElapsed time - {ElapsedTimeInSeconds(ticks, DateTime.Now.Ticks)} seconds.");
                        GC.Collect();
                    }
                    catch (Exception ex)
                    {
                        CompressionDoneEventHandler?.Invoke(true, ex.Message);
                    }
                }); 
        }

        private string ElapsedTimeInSeconds(long start, long end)
        {
            return ((double)(end - start) / 10000000).ToString(("0.###"));
        }

        public void Decompress(string fileName)
        {
            try
            {
                var file = File.ReadAllBytes(fileName);
                var arr = new byte[] { 31, 139, 8, 0, 0, 0, 0, 0, 4, 0 };
                var splitted = file.SearchBytePattern(arr);
                foreach (var item in splitted)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("hazir");
        }
    }
}
