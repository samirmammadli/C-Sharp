using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneFeWinForms
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
            _items = File.ReadLines(lang).Where(i => !i.Contains("//")).Select(x => x.Split(';')).ToDictionary(line => line[0], line => line[1]);
        }
    }

    enum Currency
    {
        AZN,
        USD,
        EUR
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
        public Currency AccCurrency { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void WriteCSV()
        {
            throw new NotImplementedException();
        }
    }
}

