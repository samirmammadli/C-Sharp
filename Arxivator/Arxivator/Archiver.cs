using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Threading;
using System.Windows;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace Arxivator
{
    class Archiver
    {

        public List<byte[]> ParseBytes(byte[] bytes, int count)
        {
            var list = new List<byte[]>();
            int chunkSize = bytes.Length / count;
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

        public void Compress(string file, ObservableCollection<int> progress, int threadsCount)
        {

            var fileBytes = File.ReadAllBytes(file);
            var inputChunks = ParseBytes(fileBytes, threadsCount);
            var threads = new List<Task<byte[]>>();
            string extension = ".gz";
            var outputChunks = new List<byte[]>();
            for (int i = 0; i < progress.Count; i++)
            {
                progress[i] = 0;
            }
            var obj = new object();
            long time = DateTime.Now.Ticks;
            for (int i = 0; i < inputChunks.Count; i++)
            {
                int iter = i;
                threads.Add(new Task<byte[]>(() =>
                {
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        using (GZipStream gZipStream = new GZipStream(mStream, CompressionMode.Compress))
                        {
                            int lenght = inputChunks[iter].Length / 100;
                            if (lenght < 1)
                            {
                                gZipStream.Write(inputChunks[iter], 0, inputChunks[iter].Length);
                                progress[iter] = 100;
                            }
                            else
                            {
                                for (int j = 0; j < 100; j++)
                                {
                                    gZipStream.Write(inputChunks[iter], j * lenght, lenght);
                                    progress[iter]++;
                                }
                                gZipStream.Write(inputChunks[iter], lenght * 100, inputChunks[iter].Length - lenght * 100);
                            }
                        }
                        return mStream.ToArray();
                    }
                }));
            }
            threads.ForEach(x => x.Start());
            var task2 = Task.WhenAll(threads).ContinueWith(param =>
            {
                var list = new byte[threads.Sum(x => x.Result.Length)];
                int counter = 0;
                foreach (var item in threads)
                {
                    foreach (var item2 in item.Result)
                    {
                        list[counter] = item2;
                        counter++;
                    }
                }
                File.WriteAllBytes(file + extension, list);
                MessageBox.Show($"Success! Elapsed time - {(DateTime.Now.Ticks - time) / 1000}");
                GC.Collect();
            });
        }

        public void Decompress(string fileName)
        {

        }
    }
}
