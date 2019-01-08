using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace EratosthenesSieve
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(typeof(BooleanSwitch).Name);

            //int number = 5;

            //55

            //Console.WriteLine(1017 % 20); //17

            ////35 - 17 = 28

            //Console.WriteLine(28 / 20);


            //var file = File.ReadAllLines(@"C:\Users\Samir\Desktop\corp.txt");


            //var begin = "BEGIN:VCARD";
            //var version = "VERSION:2.1";
            //var name = "FN:";
            //var email = "EMAIL;PREF;INTERNET:";
            //var end = "END:VCARD";


            //int index = 1;

            //foreach (var item in file)
            //{
            //    var parsed = item.Split(';');

            //    try
            //    {

            //        string[] output = new string[]
            //        {
            //            begin,
            //            version,
            //            name + parsed[0],
            //            email + parsed[1],
            //            end
            //        };

            //        int lenth = 15;

            //        if (parsed[0].Length <= 15)
            //            lenth = parsed[0].Length - 1;

            //        Console.WriteLine(index);

            //        File.WriteAllLines(@"C:\Users\Samir\Desktop\VCFKI\" + index + parsed[0].Substring(0, lenth) + ".vcf", output);

            //        //Console.WriteLine(parsed[0] + "   " + parsed[1]);

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message  + "   " + index);

            //    }

            //    index++;
            //}

            //Console.WriteLine(FactorialCalculate(number));




            //int n = int.Parse(Console.ReadLine());
            //var startTime = new Stopwatch();
            //startTime.Start();
            //bool[] A = new bool[n];
            //// Инициализация и вывод массива
            //for (int i = 2; i < n; i++)
            //{
            //    A[i] = true;
            //}

            //// Обработка
            //for (int i = 2; i < Math.Sqrt(n) + 1; ++i)
            //{
            //    if (A[i])
            //    {
            //        for (int j = i * i; j < n; j += i)
            //        {
            //            A[j] = false;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //// Повторный вывод
            //for (int i = 2; i < n; i++)
            //    if (A[i])
            //        Console.WriteLine(i);
            //startTime.Stop();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"{startTime.Elapsed.TotalMilliseconds} - my method");
            //Console.ResetColor();

            //startTime.Reset();
            //startTime.Start();
            //bool isSimple = true;
            //for (int i = 1; i < n; i++)
            //{

            //    isSimple = true;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isSimple = false;
            //            break;
            //        }
            //    }
            //    if (isSimple)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //startTime.Stop();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"{startTime.Elapsed.TotalMilliseconds} - your method");
            //Console.ResetColor();
        }

        static public int FactorialCalculate(int number)
        {
            if (number - 1 != 0)
                return number *= FactorialCalculate(number - 1);
            return number;
        }

    }
}






//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net;
//using System.Runtime.InteropServices;
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
//            var timer = new Stopwatch();
//            int num = Convert.ToInt32(Console.ReadLine());

//            timer.Start();
//            for (int i = 1; i < num; i++)
//            {

//                bool isSimple = true;
//                for (int j = 2; j <= i / 2; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        isSimple = false;
//                        break;
//                    }
//                }
//                if (isSimple)
//                {
//                    Console.WriteLine(i);
//                    i++;
//                }
//            }
//           timer.Stop();

//            Console.WriteLine("My method: " + timer.Elapsed.TotalMilliseconds);

//            timer.Reset();
//            timer.Start();
//            for (int i = 0; i < num; i++)
//            {
//                if (IsPrime(i))
//                    Console.WriteLine(i);
//            }
//            timer.Stop();
//            Console.WriteLine("Sqrt method " + timer.Elapsed.TotalMilliseconds);
//        }

//        static bool IsPrime(int num)
//         {
//            if (num == 0) return false;
//            if (num == 1) return true;
//            if (num % 2 == 0) return false;

//            int limit = (int)Math.Floor(Math.Sqrt(num));

//            for (int i = 3; i <= limit; i++)
//            {
//                if (num % i == 0)
//                {
//                    return false;
//                }
//            }

//            return true;
//        }
//    }
//}
