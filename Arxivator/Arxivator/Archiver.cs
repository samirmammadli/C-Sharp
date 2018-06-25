using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace Arxivator
{
    class Archiver
    {
        public void Compress(string fileName)
        {
            var fileBytes = File.ReadAllBytes(fileName);
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

        public void Decompress(string fileName)
        {

        }
    } 
}
