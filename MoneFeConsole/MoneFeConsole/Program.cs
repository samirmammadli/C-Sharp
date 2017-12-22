using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyFeConsole
{
    enum InterfaceItems
    {
        //Buttons
        ok,
        cancel,

        //Categories
        bills,
        car,
        clothes,
        communications,
        eating_out,
        entertainment,
        food,
        gifts,
        health,
        house,
        pets,
        sports,
        taxi,
        toiletry,
        transport,

        //Account
        deposits,
        salary,
        saving
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
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,0};

            Console.WriteLine(list[(int)SubscriptionType.Yearly]);
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
