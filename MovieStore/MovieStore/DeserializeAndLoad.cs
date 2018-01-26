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
        static public object LoadSavedData<T>(string filename)
        {
            try
            {
                var formatter = new BinaryFormatter();
                if (File.Exists("MovieStore.dat"))
                {
                    using (FileStream fs = new FileStream("MonefyData.dat", FileMode.Open))
                    {
                        return formatter.Deserialize(fs);
                    }
                }
                else
                    throw new ArgumentException("File not found!");
            }
            catch (Exception)
            {
                throw;
            }

        }
        static public void SaveData<T>(string path, T data)
        {
            var formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
