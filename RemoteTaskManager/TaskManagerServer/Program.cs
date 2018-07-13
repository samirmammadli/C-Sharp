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
    //public class ClientInfo
    //{
    //    public string IP { get; set; }
    //    public string Port { get; set; }
    //    public string Text { get; set; }
    //    public TcpClient Client { get; set; }

    //    public ClientInfo(string ip, string port, TcpClient client)
    //    {
    //        IP = ip;
    //        Port = port;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Client Ip: {IP}\n" +
    //               $"Client Port: {Port}\n" +
    //               $"Client Message: {Text}";
    //    }
    //}

    public class TasksServer
    {
        string msg = "";
        static int port = 8005;
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
                    string clientIP = client.Client.RemoteEndPoint.ToString().Split(':')[0];
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
                            lock (this) { i--; }
                            Console.WriteLine("viwel");
                            stream.Close();
                            client.Close();
                            break;
                        }
                    }
                });
            }
        }
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            var srv = new TasksServer();
            srv.StartServer();
        }
    }
}
