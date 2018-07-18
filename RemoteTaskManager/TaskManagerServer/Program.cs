using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TasksInfo;

namespace TaskManagerServer
{

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

        private List<ProcessInfo> GetProcessesInfo(Process[] processes)
        {
            var ProcessesInfo = new List<ProcessInfo>();
            foreach (var item in processes)
            {
                try
                {
                    var info = new ProcessInfo(item.ProcessName, item.Id, item.NonpagedSystemMemorySize64);
                    ProcessesInfo.Add(info);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return ProcessesInfo;
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
                client.SendBufferSize = 4000000;
                Console.WriteLine($"Client {++i} connected!");
                Task.Run(() =>
                {
                    string clientIP = client.Client.RemoteEndPoint.ToString().Split(':')[0];
                    var stream = client.GetStream();
                    while (true)
                    {
                        try
                        {
                            byte[] buffer = new byte[255];
                            msg = "";
                            do
                            {
                                buffer = new byte[255];
                                int readed = stream.Read(buffer, 0, buffer.Length);
                                msg += Encoding.UTF8.GetString(buffer, 0, readed);
                            }
                            while (stream.DataAvailable);
                            Console.WriteLine(msg);
                            if (msg.Length > 0)
                            {
                                var procs = Process.GetProcesses();
                                var procsInfo = GetProcessesInfo(Process.GetProcesses());
                                var formatter = new BinaryFormatter();
                                formatter.Serialize(stream, procsInfo);
                            }
                        }
                        catch (Exception ex)
                        {
                            lock (this) { i--; }
                            Console.WriteLine($"Disconnected");
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
