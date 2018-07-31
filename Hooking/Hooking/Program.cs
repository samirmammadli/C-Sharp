using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

static class MyClass
{
    [DllImport("user32.dll")]
    static extern int GetKeyNameText(int lParam, [Out] StringBuilder lpString,
  int nSize);

    [DllImport("user32.dll")]
    public static extern short GetAsyncKeyState(int vKey);

}

namespace Hooking
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(10);
                for (Int32 i = 0; i < 255; i++)
                {
                    int keyState = MyClass.GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32767)
                    {
                        Console.WriteLine((Keys)i);
                        break;
                    }
                }
            }
        }
    }
}
