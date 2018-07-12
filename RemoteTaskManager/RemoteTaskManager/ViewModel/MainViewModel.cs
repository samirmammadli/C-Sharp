using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RemoteTaskManager.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        static string ip = "127.0.0.1";
        static int port = 8005;
        private TcpClient client;

        public MainViewModel()
        {
            client = new TcpClient();
            client.Connect(ip, port);
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
            using (var stream = client.GetStream())
            {
                using (var writer = new StreamWriter(stream, Encoding.Unicode))
                {
                    writer.WriteLine(message);
                    writer.Flush();
                }
            }
        }

    }
}
