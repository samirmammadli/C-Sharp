using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo original = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

           var u = Directory.GetCurrentDirectory();
            var path = 
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop";
            DirectoryInfo dir = new DirectoryInfo(u);
            var dirs = dir.GetDirectories();
            var files = dir.GetFiles();

            Console.WriteLine(u);

            foreach (var item in dirs)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in files)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
