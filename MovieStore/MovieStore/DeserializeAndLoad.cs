using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    static public class DeserializeAndLoad
    {
        static public object LoadSavedData(string filename)
        {
            object obj = null;
            try
            {
                var formatter = new BinaryFormatter();
                if (File.Exists(filename))
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        obj = formatter.Deserialize(fs);
                    }
                }
                else
                    throw new ArgumentException("File not found!");
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }
        static public void SaveData<T>(string path, T data)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
            }
        }
    }
}
