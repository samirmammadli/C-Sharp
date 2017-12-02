using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Manager
{
    abstract class Storage
    {
        public string Name { get; protected set; }
        protected int _writeSpeed;
        protected int _readSpeed;

        public Storage(string name, int writespeed, int readspeed)
        {
            _writeSpeed = writespeed;
            _readSpeed = readspeed;
        }
    }

    class Dvd : Storage
    {
    }

internal static class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
