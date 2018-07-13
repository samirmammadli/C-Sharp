using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteTaskManager.ViewModel
{
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
                return sendMessage ?? (sendMessage = new RelayCommand<string>(param =>
                SendMsg(param)));
            }
        }

        public void SendMsg(string message)
        {
            
            var msg2 = Encoding.Unicode.GetBytes(message);
                stream.Write(msg2, 0, msg2.Length);
        }

        private void StartServer()
        {
            client = new TcpClient();
            client.Connect(ip, port);
            stream = client.GetStream();
            buffer = new byte[256];
            
        }

    }
}
