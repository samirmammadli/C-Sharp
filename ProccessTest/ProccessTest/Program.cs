using System;
using System.Diagnostics;
using System.Reflection;

namespace ProccessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = Process.GetProcesses();

            foreach (var item in proc)
            {
                Console.WriteLine(item.ProcessName);
            }
        }
    }
}
