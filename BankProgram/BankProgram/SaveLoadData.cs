using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankProgram
{
    static class SaveLoadData
    {
     

        static public List<T> LoadData<T>(string path)
        {
            if (File.Exists(path))
            {
                var formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    if (fs.Length > 0)
                    {
                        try
                        {
                            return formatter.Deserialize(fs) as List<T>;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                }
                return new List<T>();
            }
            
            return new List<T>();
        }

        static public void SaveData<T>(List<T> list, string path)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}