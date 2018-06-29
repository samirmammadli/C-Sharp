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
            if (chunkSize < 2)
            { list.Add(bytes);
                return list;
            }

            for (int i = 0; i < count - 1; i++)
            {
                var chunk = new byte[chunkSize];
                Buffer.BlockCopy(bytes, chunkSize * i, chunk, 0, chunkSize);
                list.Add(chunk);
            }

            var rest = bytes.Length - chunkSize * count;
            var chunk1 = new byte[rest];
            Buffer.BlockCopy(bytes, chunkSize * count, chunk1, 0, rest);
            list.Add(chunk1);
            return list;
        }

        public void Compress(string file, ObservableCollection<int> progress)
        {
            var fileBytes = File.ReadAllBytes(file);
            string extension = ".gz";
            int i = 0;
            while (File.Exists(file + extension))
            {
                extension = $"({i++}).gz";
            }
            var task = new Task(() =>
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (GZipStream gZipStream = new GZipStream(mStream, CompressionMode.Compress))
                    {
                        int lenght = fileBytes.Length / 100;
                        for (int j = 0; j < 100; j++)
                        {
                            gZipStream.Write(fileBytes, j * lenght, lenght);
                            progress[0]++;
                        }
                        gZipStream.Write(fileBytes, lenght * 100, fileBytes.Length - lenght * 100);
                    }
                    File.WriteAllBytes(file + extension, mStream.ToArray());
                }
            });
            task.Start();
            var task2 = Task.WhenAll(task).ContinueWith(param => { MessageBox.Show("File Successfully compressed!"); });
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
