﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TasksInfo;
using TasksManagarCommands;

namespace RemoteTaskManager.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            //StartServer();
        }
        static private int _port = 8005;

        private TcpClient _client;
        private NetworkStream _stream;

        private List<ProcessInfo> processes;
        public List<ProcessInfo> Processes
        {
            get => processes;
            set => Set(ref processes, value);
        }


        private ProcessInfo currentProcess;
        public ProcessInfo CurrentProcess
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

        private bool isConnected;
        public bool IsConnected
        {
            get => isConnected;
            set => Set(ref isConnected, value);
        }

        private RelayCommand getProcesses;
        public RelayCommand GetProcesses
        {
            get
            {
                return getProcesses ?? (getProcesses = new RelayCommand(() => {
                    var cmd = new GetProcessesCommand();
                    var formatter2 = new BinaryFormatter();
                    formatter2.Serialize(_stream, cmd);
                }));
            }
        }

        private RelayCommand killCommand;
        public RelayCommand KillCommand
        {
            get
            {
                return killCommand ?? (killCommand = new RelayCommand(() =>
                {
                    var cmd = new KillProcessCommand { CommandParameter = CurrentProcess.Id.ToString() };
                    var formatter2 = new BinaryFormatter();
                    formatter2.Serialize(_stream, cmd);
                }));
            }
        }

        private RelayCommand<string> connectToServer;
        public RelayCommand<string> ConnectToServer
        {
            get
            {
                return connectToServer ?? (connectToServer = new RelayCommand<string>(param =>
                Connect(param)));
            }
        }

        public void SendMsg(string message)
        {
            var msg2 = Encoding.UTF8.GetBytes(message);
                _stream.Write(msg2, 0, msg2.Length);
        }

        private void Connect(string ip)
        {
            try
            {
                if (_client != null && _client.Connected) _client.Close();
                _client = new TcpClient();
                _client.Connect(ip, _port);
                _stream = _client.GetStream();

                Task.Run(() =>
                {
                    while (true)
                    {
                        try
                        {
                            if (_client.Available > 0)
                            {
                                var formatter = new BinaryFormatter();
                                var obj = formatter.Deserialize(_stream);
                                if (obj as List<ProcessInfo> != null) (Processes = obj as List<ProcessInfo>).OrderBy(x => x.ProcessName).ToList();
                                else if (obj as string != null) MessageBox.Show(obj.ToString());
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

        private void StartServer()
        {
            try
            {
                _client = new TcpClient();
                _client.Connect("127.0.0.1", _port);
                _stream = _client.GetStream();

                var cmd = new GetProcessesCommand();
                var formatter2 = new BinaryFormatter();
                formatter2.Serialize(_stream, cmd);

                Task.Run(() =>
                {
                    while(true)
                    {
                        try
                        {
                            if (_client.Available > 0)
                            {
                                var formatter = new BinaryFormatter();
                                var obj = formatter.Deserialize(_stream) as List<ProcessInfo>;
                                if (obj != null) Processes = obj.OrderBy(x => x.ProcessName).ToList();
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
