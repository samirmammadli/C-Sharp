using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFeConsole
{
    class InterfaceItems
    {
        const string _enPath = @"lang\en.txt";
        const string _ruPath = @"lang\ru.txt";
        public Dictionary<string, string> _items;
        public InterfaceItems(string lang)
        {
            _items = new Dictionary<string, string>();
            if (lang == "ru")
                lang = _ruPath;
            else
                lang = _enPath;
            LoadLang(lang);
        }
        void LoadLang(string lang)
        {
           _items = File.ReadLines(lang).Where(i => !i.Contains("//")).Select(x => x.Split(';')).ToDictionary(line => line[0], line => line[1] );
        }
    }


    class Localization
    {

    }

    enum SubscriptionType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }


    interface ICSVWritable
    {
        void WriteCSV();
    }

    class MoneyOperation : ICSVWritable, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void WriteCSV()
        {
            throw new NotImplementedException();
        }
    }

    class Subscription : ICSVWritable, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void WriteCSV()
        {
            throw new NotImplementedException();
        }
    }


    class Account : ICSVWritable, IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void WriteCSV()
        {
            throw new NotImplementedException();
        }
    }


    class Category
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Language: \"en\" or \"ru\"");
            string lang = Console.ReadLine();

            InterfaceItems itm = new InterfaceItems(lang);

            //foreach (var item in itm._items)
            //{
            //    Console.WriteLine($"{item.Key} --> {item.Value}");
            //}

            Console.WriteLine(itm._items["ok"]);
            Console.Read();

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,0};

            //Console.WriteLine(list[(int)SubscriptionType.Yearly]);
            //Income
            //Outcome
            //Categories
            //Currencies
            //Accounts
            //Subscriptions

            //Events
            //RunOutOfMoney
            //Subscription

            ////Classes & Interfaces
            //ICSVWritable
            //    Write()

            //IConsoleWritable
            //    Write()

            //MoneyOperation : ICSVWritable, IConsoleWritable, IComparable
            //    Amount
            //    Category
            //    Note
            //    Date

            //Category
            //    Name
            //    Type (Income \ Outcome)

            //Subscription : ICSVWritable, IConsoleWritable, IComparable
            //    Name
            //    Amount
            //    StartDate
            //    EndDate
            //    SubscriptionType

            //SubscriptionType { Daily, Weekly, Monthly, Yearly }

            //Account : ICSVWritable, IConsoleWritable, IComparable
            //    Name
            //    Currency
            //    Money
            //    Hidden

            //Application
            //    Incomes[]
            //    Outcomes[]
            //    Accounts[]
            //    Categories[]
            //    Subscriptions[]

            //Data
            //Sorted incomes list (by category, by note, by date)
            //Sorted outcomes list (by category, by note, by date)

            //FileManager
            //    CSV
            //    Data
            //    Settings
            //    Languages
            //    Currencies

            //static Settings
            //    Currency
            //    Language
            //    ...

            //Language
            //    Name
            //    File

            //Text
            //    Language
            //    [phrase]

            //Text["balance"]
            //Text["income"]
            //Text["outcome"]

            //"csv_export"  "Export to CSV" "Экспорт в CSV"
            //Save data to encrypted binary file
            //Save settings to the XML
            //Currencies from XML
        }
    }
}
