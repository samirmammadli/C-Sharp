using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerServer
{
    public class Message
    {
        public string IP { get; set; }
        public string Text { get; set; }
    }

    public class TaskServer
    {
        string msg;
        static int port = 8005; // порт для приема входящих запросов
        static string ip = "127.0.0.1";
        public void StartServer()
        {
            Console.OutputEncoding = Encoding.UTF8;
            TcpListener server = new TcpListener(IPAddress.Parse(ip), port);
            server.Start();
            byte[] buffer = new byte[255];

            while (true)
            {
                var listener = server.AcceptTcpClient();
                string ip = listener.Client.RemoteEndPoint.ToString();
                using (var stream = listener.GetStream())
                {
                    int count = 0;
                    while ((count = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        msg = Encoding.Unicode.GetString(buffer, 0, count);
                    }

                    var msg2 = Encoding.Unicode.GetBytes("sam ti salam, suka");
                    stream.Write(msg2, 0, msg2.Length);
                    Console.WriteLine("Vode srabotalo");

                }
                Console.WriteLine(msg + "    " + ip);
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var srv = new TaskServer();
            srv.StartServer();
        }
    }
}
