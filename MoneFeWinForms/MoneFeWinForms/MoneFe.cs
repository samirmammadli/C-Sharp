using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MoneFeWinForms
{
    enum Languages
    {
        EN, 
        RU
    }

    class MoneFyTranslate
    {
        private const string _ruPath = @"lang\ru\";
        private const string _enPath = @"lang\en\";
        private static List<string> Categories { get; set; }
        private static List<string> AppInterface { get; set; }
        private static List<string> Account { get; set; }

        private string CheckLang(Languages lang)
        {
            if (lang == Languages.RU)
                return _ruPath;
            else
                return _enPath;
        }

        public Dictionary<string, string> LoadCategories(Languages lang)
        {
            
            Categories = File.ReadLines(CheckLang(lang) + "categories.txt").ToList();
            return getCategories();

        }

        private void LoadCategoryDefaultValues()
        {
            Categories = new List<string>()
            {
                "Car",
                "clothes",
                "eating_our",
                "entertainment",
                "food",
                "gifts",
                "communications",
                "health",
                "house",
                "pets",
                "sports",
                "taxi",
                "toiletry",
                "transport"
            };
        }

        private Dictionary<string, string> getCategories()
        {
            return new Dictionary<string, string>()
                {
                    { "cars", Categories[0] },
                    { "clothes", Categories[1] },
                    { "eating_our", Categories[2] },
                    { "entertainment", Categories[3] },
                    { "food", Categories[4] },
                    { "gifts", Categories[5] },
                    { "communications", Categories[6] },
                    { "health", Categories[7] },
                    { "house", Categories[8] },
                    { "pets", Categories[9] },
                    { "sports", Categories[10] },
                    { "taxi", Categories[11] },
                    { "toiletry", Categories[12] },
                    { "transport", Categories[13] }
                };
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
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
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
        public bool Hidden { get; set; }
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

    class MoneFyBuild
    {
        public List<Account> Accounts { get; set; }
    }
}

