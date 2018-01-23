using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Office.Core;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"https://randomuser.me/api/?format=xml&results=1000");


            //var a = from item in root.Elements()
            //        where item.Name != "info"
            //        where item.Element("nat").Value == "DE"
            //        select item;

            //var a = from item in root.Elements()
            //    where item.Name != "info"
            //    where item.Element("nat").Value == "DE"
            //    select item;

            //var a = from item in root.Elements()
            //    where item.Name != "info"
            //    where item.Element("name").Element("first").Value.StartsWith("a")
            //    select item;

            var a = from item in root.Elements()
                where item.Name != "info"
                orderby item.Element("registered")
                select item;


            foreach (var item in a)
            {
               
                //Console.WriteLine(item.Element("gender").Value);
                //Console.WriteLine(item.Element("nat")?.Value);
                //Console.WriteLine(item.Element("name").Element("first").Value);
                Console.WriteLine(item.Element("registered").Value);
            }



            //XElement root = XElement.Load("../../XMLFile1.xml");

            //var query = from user in root.Elements()
            //            where int.Parse(user.Element("age").Value) == 20
            //            select user;

            //var query = from user in root.Elements()
            //            where int.Parse(user.Attribute("id").Value) == 1
            //            select user;

            //var query = from user in root.Elements()
            //            orderby int.Parse(user.Attribute("id").Value)
            //            select user;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            //var query = from user in root.Elements()
            //            group user by user.Element("age").Value into grp
            //            select grp;

            //foreach (var group in query)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"\t{item.Value}");
            //    }
            //}



            //var query = from user in root.Elements()
            //            //where user.Element("dog") != null 
            //            where user.Element("dog")?.Elements().Count() > 1
            //            select user;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}



        }
    }
}
