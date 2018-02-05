using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LINQ_Search
{
    class Search
    {
        public void LoadUsers()
        {
            List<User> users = new List<User>();

            XElement root = XElement.Load("../../XMLFile1.xml");

            XmlSerializer formatter = new XmlSerializer(typeof(User));
            foreach (var item in root.Elements())
            {
                using (MemoryStream stringInMemoryStream = new MemoryStream(ASCIIEncoding.Default.GetBytes(item.ToString())))
                {
                    try
                    {
                        users.Add(formatter.Deserialize(stringInMemoryStream) as User);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
        }
    }
}
