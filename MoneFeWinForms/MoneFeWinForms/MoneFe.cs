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

    class MoneFeItemsLanguage
    {
        private const string _ruPath = @"lang\ru\";
        private const string _enPath = @"lang\en\";
        static private string _currentPath;
        static private List<string> Categories { get; set; }
        static private List<string> AppInterface { get; set; }
        static private List<string> Account { get; set; }

        static private bool CheckLang(Languages lang)
        {
            if (lang == Languages.RU)
            {
                _currentPath = _ruPath;
                return true;
            }
            else
                return false;
        }

        static public Dictionary<string, string> LoadCategories(Languages lang = Languages.EN)
        {
            if (CheckLang(lang) && File.Exists(_currentPath + "categories.txt") && File.ReadAllLines(_ruPath + "categories.txt").Length == 15)
                Categories = File.ReadLines(_currentPath + "categories.txt").ToList();
            else
                LoadCategoryDefaultValues();
            return getCategories();
        }

        static public Dictionary<string, string> LoadAppInterface(Languages lang = Languages.EN)
        {
            if (CheckLang(lang) && File.Exists(_currentPath + "interface.txt") && File.ReadAllLines(_ruPath + "interface.txt").Length == 6)
                AppInterface = File.ReadLines(_currentPath + "interface.txt").ToList();
            else
                LoadAppInterfaceDefaultValues();
            return getAppInterface();
        }

        static private void LoadCategoryDefaultValues()
        {
            Categories = new List<string>()
            {
                "Category",
                "Car",
                "Clothes",
                "Eating out",
                "Entertainment",
                "Food",
                "Gifts",
                "Communications",
                "Health",
                "House",
                "Pets",
                "Sports",
                "Taxi",
                "Toiletry",
                "Transport"
            };
        }

        static private void LoadAppInterfaceDefaultValues()
        {
            AppInterface = new List<string>()
            {
                "File",
                "Language",
                "English",
                "Russian",
                "Exit",
                "Are you sure you want to exit?"
            };
        }

        static public Dictionary<string, string> getCategories()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "category", Categories[i++] },
                    { "cars", Categories[i++] },
                    { "clothes", Categories[i++] },
                    { "eating_our", Categories[i++] },
                    { "entertainment", Categories[i++] },
                    { "food", Categories[i++] },
                    { "gifts", Categories[i++] },
                    { "communications", Categories[i++] },
                    { "health", Categories[i++] },
                    { "house", Categories[i++] },
                    { "pets", Categories[i++] },
                    { "sports", Categories[i++] },
                    { "taxi", Categories[i++] },
                    { "toiletry", Categories[i++] },
                    { "transport", Categories[i++] }
                };
        }

        static public Dictionary<string, string> getAppInterface()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "file", AppInterface[i++] },
                    { "language", AppInterface[i++] },
                    { "lang_english", AppInterface[i++] },
                    { "lang_russian", AppInterface[i++] },
                    { "exit", AppInterface[i++] },
                    { "exit_warning", AppInterface[i++] }
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
        public Dictionary<string, string> Categories { get; set; }
        public Dictionary<string, string> Interface { get; set; }
        public MoneFyBuild(Languages lang)
        {
            LoadLang(lang);// (Languages.RU);
            //string sad = Categories["cars"];
            //Console.WriteLine(sad);
        }
        public void LoadLang(Languages lang)
        {
            Categories = MoneFeItemsLanguage.LoadCategories(lang);
            Interface = MoneFeItemsLanguage.LoadAppInterface(lang);
        }
    }
}

