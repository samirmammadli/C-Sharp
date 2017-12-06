using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Manager
{

    abstract class Storage
    {
        protected bool _type;
        protected double _usedSpace;

        public double WriteSpeed { get; protected set; }
        public double ReadSpeed { get; protected set; }
        public string StorageName { get; protected set; }
        public double Capacity { get; protected set; }
        public double FreeSpace { get => Capacity - _usedSpace; }

        public Storage(string name, double capacity, bool type)
        {
            StorageName = name;
            Capacity = capacity;
            _type = type;
            _usedSpace = 0;
        }

        public void FormatDevice() { _usedSpace = 0; }

        public int WriteData(double fileSize, int count)
        {
            if (count < 1) throw new ArgumentException("Count cannot be less tha 1!");
            if (fileSize > FreeSpace) return 0;
            else
            {
                if (FreeSpace < fileSize * count)
                {
                    var filesCount = FreeSpace / fileSize;
                    _usedSpace += fileSize * (int)filesCount;
                    return (int)filesCount;
                }
                else
                {
                    _usedSpace += fileSize * count;
                    return count;
                }
            }  
        }
    }

    class DVD : Storage
    {
        public DVD(string name, bool dubleSide) : base(name, 0, dubleSide)
        {
            WriteSpeed = 10.56;
            ReadSpeed = WriteSpeed;
            if (dubleSide) Capacity = 9; else Capacity = 4.7;
        }
    }

    class Flash : Storage
    {
        public Flash(string name, double capacity, bool USb3) : base(name, capacity, USb3)
        {

            if (USb3)
            {
                WriteSpeed = 76.15;
                ReadSpeed = 92.74;
            }
            else
            {
                WriteSpeed = 22.54;
                ReadSpeed = 29.30;
            }
        }
    }

    class HardDisk : Storage
    {
        public HardDisk(string name, double capacity, bool SSD) : base(name, capacity, SSD)
        {
            if (SSD)
            {
                WriteSpeed = 226.38;
                ReadSpeed = 274.18;
            }
            else
            {
                WriteSpeed = 54.64;
                ReadSpeed = 71.3;
            }
        }
    }


    class StorageMass
    {
        private List<Storage> devices;
        public StorageMass()
        {
            devices = new List<Storage>();
        }
        public void AddDevice(Storage device)
        {
            if (device == null)
                throw new NullReferenceException();
            devices.Add(device);
        }
        public void WriteData (double filesize, int count)
        {
            if (count < 1) throw new ArgumentException("Count cannot be less tha 1!");
            int writtenCount = 0;
            for (int i = 0; i < devices.Count && writtenCount != count; i++)
            {
                writtenCount += devices[i].WriteData(filesize, count - writtenCount);
            }
        }
    }

internal static class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
