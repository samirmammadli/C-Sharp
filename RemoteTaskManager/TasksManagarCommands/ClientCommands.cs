using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TasksInfo;

namespace TasksManagarCommands
{
    public interface IClientCommand
    {
        void ExecuteCommand(NetworkStream stream);
    }

    [Serializable]
    public class GetProcessecCommand : IClientCommand
    {
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

        public void ExecuteCommand(NetworkStream stream)
        {
            var procs = Process.GetProcesses();
            var procsInfo = GetProcessesInfo(Process.GetProcesses());
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, procsInfo);
        }
    }
}
