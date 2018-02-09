using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Office.Core;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[8]{255,255,255,255,0,0,0,0 };
            var i = BitConverter.ToUInt64(a, 0);
            Console.WriteLine(i);
            Console.WriteLine(ulong.MaxValue);
        }
    }
}
