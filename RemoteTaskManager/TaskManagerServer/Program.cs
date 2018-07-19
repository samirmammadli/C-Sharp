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
using TasksManagarCommands;

namespace TaskManagerServer
{
    public class ClientInfo
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }

        public ClientInfo(int id, string iP, string port)
        {
            Id = id;
            IP = iP;
            Port = port;
        }
    }

    public class TasksServer
    {
        static private int idCounter = 0;
        static private int port = 8005;
        static private string ip = "127.0.0.1";
        public Dictionary<ClientInfo, TcpClient> Connections { get; set; }
        public TasksServer()
        {
            Connections = new Dictionary<ClientInfo, TcpClient>();
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

        private bool GetCommand(NetworkStream stream, TcpClient client)
        {
            var formatter = new BinaryFormatter();
            try
            {
                
                var command = formatter.Deserialize(stream) as IClientCommand;
                command?.ExecuteCommand(stream);
                return true;
            }
            catch (Exception)
            {
                var disconnectedClient = Connections.Where(x => x.Value == client).FirstOrDefault().Key;
                Connections.Remove(disconnectedClient);
                ConnectionStatusReport(disconnectedClient, false);
                stream?.Close();
                client?.Close();
                return false;
            }
        }

        private void ConnectionStatusReport(ClientInfo clientInfo, bool isConnected)
        {
            string connectionStatus = isConnected ? "Connected" : "Disconnected";
            Console.WriteLine($"{connectionStatus} {DateTime.Now}\n" +
                    $"Id: {clientInfo.Id}\n" +
                    $"IP: {clientInfo.IP}\n" +
                    $"Port: {clientInfo.Port}\n\n"
                    );
        }

        async public void StartServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(ip), port);
            listener.Start();
            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
                idCounter++;
                string[] clientInfo = client.Client.RemoteEndPoint.ToString().Split(':');
                Connections.Add(new ClientInfo(idCounter, clientInfo[0], clientInfo[1]), client);
                ConnectionStatusReport(Connections.LastOrDefault().Key, true);
                var stream = client.GetStream();
            #pragma warning disable CS4014
                Task.Run(() => {while (GetCommand(stream, client)) { } });
            #pragma warning restore CS4014 
            }
        }
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            var srv = new TasksServer();
            srv.StartServer();
            Console.ReadKey();
        }
    }
}
