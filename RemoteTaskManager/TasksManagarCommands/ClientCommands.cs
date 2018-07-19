using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        string CommandParameter { get; set; }
        void ExecuteCommand(NetworkStream stream);
    }

    [Serializable]
    public class KillProcessCommand : IClientCommand
    {
        public string CommandParameter { get; set; }
        public void ExecuteCommand(NetworkStream stream)
        {
            try
            {
                var process = Process.GetProcessById(Int32.Parse(CommandParameter));
                process?.Kill();
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Success!");
                }
            }
            catch (Exception ex)
            {

                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(ex.Message);
                }
            }
            
        }
    }

    [Serializable]
    public class GetProcessesCommand : IClientCommand
    {
        public string CommandParameter { get; set; }
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
                catch (Exception)
                {
                    throw;
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
