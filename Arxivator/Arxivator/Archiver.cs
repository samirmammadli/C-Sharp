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
        static public int counter = 0;

        public void Compress(string file, ObservableCollection<int> threads)
        {
            var threadstart = new ThreadStart(() =>
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
            var thread = new Thread(threadstart);
            thread.Start();
        }

        public void Test(object fileName)
        {
            var fileBytes = File.ReadAllBytes(fileName.ToString());
            string extension = ".gz";
            int i = 0;
            while (File.Exists(fileName + extension))
            {
                extension = $"({i++}).gz";
            }
            using (FileStream fileStream = new FileStream(fileName + extension, FileMode.Create))
            {
                using (GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress))
                {   
                    gZipStream.Write(fileBytes, 0, fileBytes.Length); 
                    
                }
            }
        }

        public void Compress2(string fileName)
        {
            ThreadPool.QueueUserWorkItem(Test, fileName);

        }

        public void Decompress(string fileName)
        {

        }
    } 
}
