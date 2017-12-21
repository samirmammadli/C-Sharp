using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string FullName;
        public int Year;
        public Test(string name, int year)
        {
            FullName = name;
            Year = year;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {

            List<Test> list = new List<Test>() {
                new Test("Samir", 1986),
                new Test("Ujal", 1995),
                new Test("OOOOOr", 1986),
                new Test("AAAlon", 1986),
                new Test("Irvinn", 1995) };

            //var hehe = from item3 in list[0].FullName
            //           group


            var poisk = (from item1 in list
                                group item1 by item1.FullName).ToList<Test>();
                        //where groups.Count() == 5
                        //select groups;

            foreach (var item in poisk)
            {
                Console.WriteLine(item.FullName); 
            }

            var group = from item2 in list
                        where item2.FullName.GroupBy(x => x).OrderByDescending(z => z.Count()).First().Count() == 5
                select item2;

            //foreach (var item in group)
            //{
            //    Console.WriteLine(item.FullName);
            //}
        }

    }
}
