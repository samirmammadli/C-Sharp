using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManagerServer
{
    public class Message
    {
        public string IP { get; set; }
        public string Text { get; set; }
    }

    public class TasksServer
    {
        string msg = "";
        static int port = 8005; // порт для приема входящих запросов
        static string ip = "127.0.0.1";
        public List<TcpClient> Connections { get; set; }

        public TasksServer()
        {
            Connections = new List<TcpClient>();
        }


        public void StartServer()
        {
            Console.OutputEncoding = Encoding.UTF8;
            TcpListener listener = new TcpListener(IPAddress.Parse(ip), port);
            listener.Start();
            int i = 0;
            while (true)
            {
                var client = listener.AcceptTcpClient();
                Console.WriteLine($"Client {++i} connected!");
                Task.Run(() =>
                {
                    string clientIP = client.Client.RemoteEndPoint.ToString();
                    var stream = client.GetStream();
                    while (true)
                    {
                        try
                        {
                            msg = "";
                            byte[] buffer = new byte[client.Available];
                            stream.Read(buffer, 0, buffer.Length);
                            msg = Encoding.Unicode.GetString(buffer, 0, buffer.Length);
                            if (msg.Length > 0) Console.WriteLine(msg + "    " + clientIP);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("viwel");
                            client.Close();
                            break;
                        }
                    }
                });
            }

        }




        // public void StartServer()
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    TcpListener server = new TcpListener(IPAddress.Parse(ip), port);
        //    byte[] buffer = new byte[255];

        //    while (true)
        //    {
        //        server.Start();
        //        var listener = server.AcceptTcpClient();
        //        string clientIP = listener.Client.RemoteEndPoint.ToString();
        //        var stream = listener.GetStream();
        //        while (listener.GetState() == TcpState.Established)
        //        {
        //            if (stream.DataAvailable)
        //            {
        //                msg = "";
        //                byte[] buffer2 = new byte[listener.Available];
        //                stream.Read(buffer2, 0, buffer2.Length);
        //                msg += Encoding.Unicode.GetString(buffer2, 0, buffer2.Length);
        //                Console.WriteLine(msg + "    " + clientIP);
        //            }
        //        }
        //        Console.WriteLine("server stopped");
        //        server.Stop();
        //    }

        //}
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            var srv = new TasksServer();
            srv.StartServer();
        }
    }

    static class ExtensionMethods
    {
        public static TcpState GetState(this TcpClient tcpClient)
        {
            var foo = IPGlobalProperties.GetIPGlobalProperties()
              .GetActiveTcpConnections()
              .SingleOrDefault(x => x.LocalEndPoint.Equals(tcpClient.Client.LocalEndPoint)
                                 && x.RemoteEndPoint.Equals(tcpClient.Client.RemoteEndPoint)
              );

            return foo != null ? foo.State : TcpState.Unknown;
        }
    }
}
