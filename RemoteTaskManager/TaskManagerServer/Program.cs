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
            
            while (true)
            {
                var listener = server.AcceptTcpClient();
                string ip = listener.Client.RemoteEndPoint.ToString();
                using (var stream = listener.GetStream())
                {
                    using (var reader = new StreamReader(stream, Encoding.Unicode))
                    {
                        msg = reader.ReadLine();
                    }
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
