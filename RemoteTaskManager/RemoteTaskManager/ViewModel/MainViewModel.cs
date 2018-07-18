using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteTaskManager.ViewModel
{
    [Serializable]
    public class ProcessInfo
    {
        public string ProcessName { get; set; }
        public int Id { get; set; }
        public long NonpagedSystemMemorySize64 { get; set; }

        public ProcessInfo(string processName, int id, long nonpagedSystemMemorySize64)
        {
            ProcessName = processName;
            Id = id;
            NonpagedSystemMemorySize64 = nonpagedSystemMemorySize64;
        }
    }


    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            StartServer();
        }

        static string ip = "127.0.0.1";
        static int port = 8005;

        private TcpClient client;
        private byte[] buffer;
        private NetworkStream stream;

        private List<Process> processes;
        public List<Process> Processes
        {
            get => processes;
            set => Set(ref processes, value);
        }
        private Process currentProcess;
        public Process CurrentProcess
        {
            get => currentProcess;
            set => Set(ref currentProcess, value);
        }

        private string incomingMsg;
        public string IncomingMsg
        {
            get => incomingMsg;
            set => Set(ref incomingMsg, value);
        }


        private RelayCommand<string> sendMessage;
        public RelayCommand<string> SendMessage
        {
            get
            {
                return sendMessage ?? (sendMessage = new RelayCommand<string>(message =>
                SendMsg(message)));
            }
        }

        public void SendMsg(string message)
        {
            var msg2 = Encoding.UTF8.GetBytes(message);
                stream.Write(msg2, 0, msg2.Length);


        }

        private void StartServer()
        {
            try
            {
                client = new TcpClient();
                client.ReceiveBufferSize = 4000000;
                client.Connect(ip, port);
                stream = client.GetStream();
                buffer = new byte[256];

                Task.Run(() =>
                {
                    while(true)
                    {
                        try
                        {
                            if (client.Available > 0)
                            {
                                //do
                                //{
                                //    byte[] buffer = new byte[255];
                                //    int readed = stream.Read(buffer, 0, buffer.Length);
                                    
                                //}
                                //while (stream.DataAvailable);
                                var formatter = new BinaryFormatter();
                                var obj = formatter.Deserialize(stream) as List<ProcessInfo>;
                                if (obj != null) MessageBox.Show("Uraaa");

                                //msg = Encoding.Unicode.GetString(buffer, 0, buffer.Length);
                                //MessageBox.Show(msg.Length.ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
