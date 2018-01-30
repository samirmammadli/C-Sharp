//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using Microsoft.Office.Core;

//namespace test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            XElement root = XElement.Load(@"https://randomuser.me/api/?format=xml&results=1000");

//            //1 Получить всех женщин
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    where item.Element("gender").Value == "female"
//                    select item;

//            //2 Получить всех немцев
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    where item.Element("nat").Value == "DE"
//                    select item;

//            //3 Получить всех людей с именем на букву А
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    where item.Element("name").Element("first").Value.StartsWith("a")
//                    select item;

//            //4 Отсортировать людей по дате регистрации
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    orderby item.Element("registered").Value
//                    select item;


//            //5 Получить человека с самым длинным именем
//            var a = (from item in root.Elements()
//                     where item.Name != "info"
//                     orderby item.Element("name")?.Element("first")?.Value.Length
//                     select item).Last();

//            //6 Сгрупировать и вывести людей по национальности
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    group item by item.Element("nat").Value
//                into grp
//                    select grp;

//            //7* Вывести страну проживания каждого человека
//            var a = from item in root.Elements()
//                    where item.Name != "info"
//                    select item;


//            foreach (var item in a)
//            {
//                Console.WriteLine(item.Element("gender").Value); ////1 Получить всех женщин
//                Console.WriteLine(item.Element("nat")?.Value); ////2 Получить всех немцев
//                Console.WriteLine(item.Element("name").Element("first").Value); ////3 Получить всех людей с именем на букву А
//                Console.WriteLine(item.Element("registered")?.Value);  ////4 Отсортировать людей по дате регистрации
//                Console.WriteLine(item.Element("location").Element("state").Value); ////7* Вывести страну проживания каждого человека
//            }


//            //5 Получить человека с самым длинным именем
//            /*Console.WriteLine(a.Element("name").Element("first").Value);*/

//            //6 Сгрупировать и вывести людей по национальности
//            foreach (var item in a)
//            {
//                Console.WriteLine(item.Key);
//                foreach (var item2 in item)
//                {
//                    Console.WriteLine("\t" + item2.Element("name").Element("first").Value);
//                }
//            }

//        }
        
//    }
//}            //var query = from user in root.Elements()
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



//        }
//    }
//}
