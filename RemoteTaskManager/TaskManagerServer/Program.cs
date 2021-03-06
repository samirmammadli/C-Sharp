﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using TasksInfo;

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
        private static int _idCounter = 0;
        private static int port = 8005;
        public Dictionary<ClientInfo, TcpClient> Connections { get; set; }
        public TasksServer()
        {
            Connections = new Dictionary<ClientInfo, TcpClient>();
        }

        private List<ProcessInfo> GetProcessesInfo(Process[] processes)
        {
            var processesInfo = new List<ProcessInfo>();
            foreach (var item in processes)
            {
                try
                {
                    var info = new ProcessInfo(item.ProcessName, item.Id, item.NonpagedSystemMemorySize64);
                    processesInfo.Add(info);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return processesInfo;
        }

        private bool GetCommand(NetworkStream stream, TcpClient client)
        {
            var clientInfo = Connections.FirstOrDefault(x => x.Value == client).Key;
            var formatter = new BinaryFormatter();
            try
            {
                var command = formatter.Deserialize(stream) as TasksManagarCommands.IClientCommand;
                lock (this) { command?.ExecuteCommand(stream); };
                Console.WriteLine($"Client {clientInfo.Id}: {command} Command executed");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Connections.Remove(clientInfo);
                ConnectionStatusReport(clientInfo, false);
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

        public void StartServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                _idCounter++;
                string[] clientInfo = client.Client.RemoteEndPoint.ToString().Split(':');
                Connections.Add(new ClientInfo(_idCounter, clientInfo[0], clientInfo[1]), client);
                ConnectionStatusReport(Connections.LastOrDefault().Key, true);
                var stream = client.GetStream();
                Task.Run(() => {while (GetCommand(stream, client)) { } });
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
