using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace test
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }

    class Test
    {
        private string FullName;
        public int Year;
        public int x;
        public Test(string name, int year)
        {
            FullName = name;
            Year = year;
        }

        public override string ToString()
        {
            return x.ToString();
        }

        public static Test operator ++(Test obj)
        {
            Test temp = new Test(obj.FullName, obj.Year);
            temp.x = obj.x;
            obj.x++;
            return temp;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //var language = "en-ru";
            //var text = "";
            //var webClient = new WebClient();
            //webClient.Encoding = Encoding.UTF8;
            //while (true)
            //{
            //    text = Console.ReadLine();
            //    text = HttpUtility.UrlEncode(text);
            //    string url =
            //        $"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20171221T171359Z.7c952e5cee5cce49.4522dd804535b842a0959725f4275cc4bf261f60&text={text}&lang={language}";
            //    var data = webClient.DownloadString(url);
            //    dynamic obj = JObject.Parse(data);
            //    Console.WriteLine(obj.text[0]);
            //    Console.Read();
            //    Console.Clear();
            //}

            Test il = new Test("Samir", 1986);
            il.x = 15;
            Console.WriteLine(il++);


        }
    }
}


//List<Test> list = new List<Test>() {
//new Test("Samir", 1986),
//new Test("Ujal", 1995),
//new Test("OOOOOr", 1986),
//new Test("AAAlon", 1986),
//new Test("Irvinn", 1995) };

////var hehe = from item3 in list[0].FullName
////           group


////string lesh = "Ahmedova irina agu";

////var slovo = from item4 in lesh
////    group item4 by x => x;

////foreach (var r in slovo)
////{
////    Console.WriteLine(r.Key);
////}

////var poisk = from item1 in list
////    group item1.FullName by 
////    into g

////    select g;
////where groups.Count() == 5
////select groups;

////foreach (var item in poisk)
////{
////    Console.WriteLine(item.Key); 
////}

//var group = from item2 in list
//where item2.FullName.GroupBy(x => x).OrderByDescending(z => z.Count()).First().Count() == 5
//select item2;


//Console.WriteLine(group.Count());
//foreach (var item in group)
//{
//Console.WriteLine(item.FullName);
//}

//}