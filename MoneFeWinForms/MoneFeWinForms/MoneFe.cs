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
            if (CheckLang(lang) && File.Exists(_currentPath + "categories.txt") && File.ReadAllLines(_ruPath + "categories.txt").Length == 12)
                Categories = File.ReadLines(_currentPath + "categories.txt").ToList();
            else
                CategoryDefaultValues();
            return getCategories();
        }

        static public Dictionary<string, string> LoadAppInterface(Languages lang = Languages.EN)
        {
            if (CheckLang(lang) && File.Exists(_currentPath + "interface.txt") && File.ReadAllLines(_ruPath + "interface.txt").Length == 11)
                AppInterface = File.ReadLines(_currentPath + "interface.txt").ToList();
            else
                AppInterfaceDefaultValues();
            return getAppInterface();
        }

        static private void CategoryDefaultValues()
        {
            Categories = new List<string>()
            {
                "Car",
                "Clothes",
                "Eating out",
                "Entertainment",
                "Food",
                "Gifts",
                "Communications",
                "Health",
                "House",
                "Sports",
                "Taxi",
                "Transport"
            };
        }

        static private void AppInterfaceDefaultValues()
        {
            AppInterface = new List<string>()
            {
                "File",
                "Language",
                "English",
                "Russian",
                "Exit",
                "Are you sure you want to exit?",
                "Income",
                "Outcome",
                "Category",
                "Add to category:",
                "Add"
            };
        }

        static private Dictionary<string, string> getCategories()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "cars", Categories[i++] },
                    { "clothes", Categories[i++] },
                    { "eating_out", Categories[i++] },
                    { "entertainment", Categories[i++] },
                    { "food", Categories[i++] },
                    { "gifts", Categories[i++] },
                    { "communications", Categories[i++] },
                    { "health", Categories[i++] },
                    { "house", Categories[i++] },
                    { "sports", Categories[i++] },
                    { "taxi", Categories[i++] },
                    { "transport", Categories[i++] }
                };
        }

        static private Dictionary<string, string> getAppInterface()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "file", AppInterface[i++] },
                    { "language", AppInterface[i++] },
                    { "lang_english", AppInterface[i++] },
                    { "lang_russian", AppInterface[i++] },
                    { "exit", AppInterface[i++] },
                    { "exit_warning", AppInterface[i++] },
                    { "income", AppInterface[i++] },
                    { "outcome", AppInterface[i++] },
                    { "category", AppInterface[i++] },
                    { "addToCategory", AppInterface[i++] },
                    { "add", AppInterface[i++] }
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
        public Currency AccCurrency { get; set; }
        public string Category { get; set; }
        public string Account { get; set; }
        public double Value { get; set; }

        public MoneyOperation(Currency currency ,string category, string account, double value)
        {
            AccCurrency = currency;
            Category = category;
            Account = account;
            Value = value;
        }

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

        public Account(Currency accCurrency, bool hidden, string accName, double balance)
        {
            AccCurrency = accCurrency;
            Hidden = hidden;
            AccName = accName;
            Balance = balance;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void WriteCSV()
        {
            throw new NotImplementedException();
        }
    }

    class MoneFyFormsBuild
    {
        public List<Account> Accounts { get; set; }
        public SortedList<DateTime, List<MoneyOperation>> Operations { get; set; }
        public Dictionary<string, string> Categories { get; set; }
        public Dictionary<string, string> Interface { get; set; }
        public MoneFyFormsBuild(Languages lang)
        {
            Operations = new SortedList<DateTime, List<MoneyOperation>>();
            ChangeLang(lang);
            Accounts = new List<Account>();
        }
        public void ChangeLang(Languages lang)
        {
            Categories = MoneFeItemsLanguage.LoadCategories(lang);
            Interface = MoneFeItemsLanguage.LoadAppInterface(lang);
            Operations.Add(DateTime.Now.Date, new List<MoneyOperation>() { new MoneyOperation(Currency.AZN, "salanm", "account", 2321.5) });
            DateTime t = new DateTime();
            t = DateTime.Now.Date;
            Console.WriteLine(Operations[t][0].Account);
            var nese = (from item in Operations
                        where item.Key >= t
                        select item).ToList();

            //Console.WriteLine(nese);

            foreach (var item in nese)
            {
                Console.WriteLine(item.Value[0].Account);
            }
        }
    }
}

