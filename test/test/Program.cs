using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Office.Core;
using MyBinaryConverter;


namespace test
{
    public class MessageHelper
    {
        [DllImport("User32.dll")]
        private static extern int RegisterWindowMessage(string lpString);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        //For use with WM_COPYDATA and COPYDATASTRUCT
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int Msg, int wParam, ref COPYDATASTRUCT lParam);

        //For use with WM_COPYDATA and COPYDATASTRUCT
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(int hWnd, int Msg, int wParam, ref COPYDATASTRUCT lParam);

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(int hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(int hWnd);

        public const int WM_USER = 0x400;
        public const int WM_COPYDATA = 0x4A;

        //Used for WM_COPYDATA for string messages
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        public bool bringAppToFront(int hWnd)
        {
            return SetForegroundWindow(hWnd);
        }

        public int sendWindowsStringMessage(int hWnd, int wParam, string msg)
        {
            int result = 0;

            if (hWnd > 0)
            {
                byte[] sarr = System.Text.Encoding.Default.GetBytes(msg);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = msg;
                cds.cbData = len + 1;
                result = SendMessage(hWnd, WM_COPYDATA, wParam, ref cds);
            }

            return result;
        }

        public int sendWindowsMessage(int hWnd, int Msg, int wParam, int lParam)
        {
            int result = 0;

            if (hWnd > 0)
            {
                result = SendMessage(hWnd, Msg, wParam, lParam);
            }

            return result;
        }

        public int getWindowId(string className, string windowName)
        {
            return FindWindow(className, windowName);
        }
    }
    static class Test
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern string SendMessage(int hWnd, int msg, string wParam, IntPtr lParam);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] a = new byte[8]{255,255,255,255,0,0,0,0 };
            //var i = BitConverter.ToUInt64(a, 0);
            //Console.WriteLine(i);
            //Console.WriteLine(ulong.MaxValue);
            //var res = BinaryConverter.ConvertToBinary(156);
            //Console.WriteLine(res);

            //Process proc = new Process();
            ////полный путь к файлу java.exe - C:\Program Files\Java\jre6\bin\java.exe 
            ////или C:\Program Files\Java\jdk1.6.0_26\bin\java
            //proc.StartInfo.FileName = @"C:\Games\Playdeon MU Online\Launcher.exe";
            ////имя исполняемого класса. Файл класса должен лежать в одной папке с приложением
            ////абсолютные пути что-то не канают 
            //proc.StartInfo.Arguments = "Program1";
            //proc.StartInfo.UseShellExecute = false;
            //proc.StartInfo.RedirectStandardOutput = true;
            //proc.StartInfo.RedirectStandardInput = true;
            //proc.StartInfo.CreateNoWindow = true;
            //string str = "";
            //proc.Start();
            //str = proc.StandardOutput.ReadToEnd();
            //proc.Close();
            //proc.Dispose();
            //Console.WriteLine(str);
            //Console.Read();
            MessageHelper msg = new MessageHelper();
            int result = 0;
            //First param can be null
            int hWnd = msg.getWindowId(null, "Edit");
            result = msg.sendWindowsStringMessage(hWnd, 0, "Some_String_Message");
            //Or for an integer message
            result = msg.sendWindowsMessage(hWnd, MessageHelper.WM_USER, 123, 456);
        }
    }
}
