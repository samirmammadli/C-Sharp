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

            for (int i = 0; i < count - 1; i++)
            {
                var chunk = new byte[chunkSize];
                Buffer.BlockCopy(bytes, chunkSize * i, chunk, 0, chunkSize);
                list.Add(chunk);
            }

            var rest = bytes.Length - chunkSize * count;
            if (rest != 0 )
            {
                var chunk1 = new byte[rest];
                Buffer.BlockCopy(bytes, chunkSize * count, chunk1, 0, rest);
                list.Add(chunk1);
            }
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
                        //lock (obj)
                        //{
                        //    var arr = mStream.ToArray();
                        //    MessageBox.Show(arr.Length.ToString());
                        //    outputChunks.Add(arr);
                        //    //MessageBox.Show(outputChunks[0].Length.ToString());
                        //}

                    }
                }));
            }
            threads.ForEach(x => x.Start());
            var task2 = Task.WhenAll(threads).ContinueWith(param =>
            {
                var list = new List<byte>();
                for (int i = 0; i < threads.Count; i++)
                {
                    MessageBox.Show(threads[i].Result.Length.ToString());
                    foreach (var item in threads[i].Result)
                    {
                        
                        list.Add(item);
                    }
                }
                
                File.WriteAllBytes(file + extension, list.ToArray());
                //using (var fs = new FileStream(file + extension, FileMode.Create))
                //{
                //    try
                //    {
                        
                //        for (int i = 0; i < threads.Count; i++)
                //        {
                //            foreach (var item in threads[i].Result)
                //            {
                //                fs.WriteByte(item);
                //            }
                //        }

                //        //int offset = 0;
                //        //for (int i = 0; i < threads.Count; i++)
                //        //{
                //        //    //MessageBox.Show(item.Result.Length.ToString());
                //        //    fs.Write(threads[i].Result, offset, threads[i].Result.Length);
                //        //    offset += threads[i].Result.Length;

                //        //    MessageBox.Show(fs.Length.ToString() + "     "  + offset.ToString());
                //        //}
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                    
                //}
                MessageBox.Show("Success!");
            });
        }

        public void CompressHazir(string file, ObservableCollection<int> threads)
        {
            var task = new Task(() =>
            {
                var fileBytes = File.ReadAllBytes(file);
                string extension = ".gz";
                int i = 0;
                while (File.Exists(file + extension))
                {
                    extension = $"({i++}).gz";
                }
                using (FileStream fileStream = new FileStream(file + extension, FileMode.Create))
                {
                    using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress))
                    {
                        int lenght = fileBytes.Length / 100;
                        for (int j = 0; j < 100; j++)
                        {
                            gZipStream.Write(fileBytes, j * lenght, lenght);
                            threads[0]++;
                        }
                        gZipStream.Write(fileBytes, lenght * 100, fileBytes.Length - lenght * 100);
                    }
                }
            });
            task.Start();
            var task2 = Task.WhenAll(task).ContinueWith(param => { MessageBox.Show("File Successfully compressed!"); });
        }

        public void Decompress(string fileName)
        {

        }
    }
}
