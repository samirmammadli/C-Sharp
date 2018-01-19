﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace MoneFeWinForms
{
    enum Languages
    {
        EN, 
        RU
    }

    enum Currency
    {
        AZN,
        USD,
        EUR
    }

    enum OperationType
    {
        Account,
        Category,
        AddBalance
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
            if (CheckLang(lang) && File.Exists(_currentPath + "interface.txt") && File.ReadAllLines(_ruPath + "interface.txt").Length == 37)
                AppInterface = File.ReadLines(_currentPath + "interface.txt").ToList();
            else
                AppInterfaceDefaultValues();
            return getAppInterface();
        }

        static private void CategoryDefaultValues()
        {
            Categories = new List<string>()
            {
                "Car", "Clothes", "Eating out", "Entertainment", "Food", "Gifts",
                "Communications", "Health", "House", "Sports", "Taxi", "Transport"
            };
        }

        static private void AppInterfaceDefaultValues()
        {
            AppInterface = new List<string>()
            {
                "File", "Language", "English", "Russian", "Exit", "Are you sure you want to exit?",
                "Income","Outcome", "Category", "Add to category:", "Add", "Add new account", "Account",
                "Currency", "Add note", "Balance", "Account name", "Period", "Year", "Month", "Week",
                "Day", "Date", "Save", "Edit", "Delete", "Cancel", "Succes", "Account successfully edited!",
                "Account successfully deleted!", "Account balance increased", "Added new account", "Summ",
                "Comment", "Export to CSV", "Change rate", "Get actual rate"
            };
        }

        static private Dictionary<string, string> getCategories()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    
                    { "cars", Categories[i++] }, { "clothes", Categories[i++] }, { "eating_out", Categories[i++] },
                    { "entertainment", Categories[i++] }, { "food", Categories[i++] }, { "gifts", Categories[i++] },
                    { "communications", Categories[i++] }, { "health", Categories[i++] }, { "house", Categories[i++] },
                    { "sports", Categories[i++] }, { "taxi", Categories[i++] }, { "transport", Categories[i++] }
                };
        }

        static private Dictionary<string, string> getAppInterface()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "file", AppInterface[i++] }, { "language", AppInterface[i++] }, { "lang_english", AppInterface[i++] },
                    { "lang_russian", AppInterface[i++] }, { "exit", AppInterface[i++] }, { "exit_warning", AppInterface[i++] },
                    { "income", AppInterface[i++] }, { "outcome", AppInterface[i++] },{ "category", AppInterface[i++] },
                    { "addToCategory", AppInterface[i++] },{ "add", AppInterface[i++] },{ "addNewAccount", AppInterface[i++] },
                    { "account", AppInterface[i++] },{ "currency", AppInterface[i++] },{ "addNote", AppInterface[i++] },
                    { "balance", AppInterface[i++] },{ "accountName", AppInterface[i++] }, { "chooseDate", AppInterface[i++] },
                    { "year", AppInterface[i++] },{ "month", AppInterface[i++] },{ "week", AppInterface[i++] },
                    { "day", AppInterface[i++] },{ "date", AppInterface[i++] }, { "save", AppInterface[i++] },
                    { "edit", AppInterface[i++] },{ "delete", AppInterface[i++] },{ "cancel", AppInterface[i++] },
                    { "successOperation", AppInterface[i++] },{ "accountEdited", AppInterface[i++] },{ "accountDeleted", AppInterface[i++] },
                    { "balanceIncrease", AppInterface[i++] },{ "newAccountAdd", AppInterface[i++] },{ "summ", AppInterface[i++] },
                    { "comment", AppInterface[i++] },{ "exportToCSV", AppInterface[i++] },{ "changeRate", AppInterface[i++] },
                    { "getActualRate", AppInterface[i++] }
                };
        }
    }

    interface ICSVWritable
    {
        void WriteCSV(string path, string category);
    }

    [Serializable]
    class MoneyOperation : ICSVWritable
    {
        public Currency AccCurrency { get; }
        public string Category { get; }
        public string Account { get; }
        public OperationType Type { get; }
        public int AccountID { get; }
        public string Notes { get; }
        public double Value { get; }

        public MoneyOperation(Currency currency ,string category, string name, int accountID, string notes, double value, OperationType type = OperationType.Category)
        {
            AccCurrency = currency;
            Category = category;
            AccountID = accountID;
            Notes = notes;
            Value = value;
            Type = type;
            Account = name;
        }

        public void WriteCSV(string path, string category)
        {
            string csv = $"{Account};{category};{Value};{AccCurrency};{Notes}" + Environment.NewLine;
            try
            {
                File.AppendAllText(path, csv,Encoding.UTF8);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }

    class CurrencyRate
    {
        public Dictionary<Currency, double> CurRates { get; set; }

        public CurrencyRate()
        {
            CurRates = new Dictionary<Currency, double> {
                {Currency.AZN, 1 },
                {Currency.USD, 1.701 },
                {Currency.EUR, 2.05 }
            };

            try
            {
                LoadRatesFromApi();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double EquateRates(Currency toThisCur, Currency cur, double sum)
        {
            if(toThisCur == cur) return sum;
            return sum * CurRates[cur] / CurRates[toThisCur];
        }

        public void LoadRatesFromApi()
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var link = $"https://www.cbar.az/currencies/{date}.xml";
            var rates = XDocument.Load(link);

            var result = from item in rates.Element("ValCurs").Elements("ValType").Elements("Valute")
                         where item.Attribute("Code").Value == "EUR" || item.Attribute("Code").Value == "USD"
                         select item;

            foreach (var item in result)
            {
                double value = Convert.ToDouble(item.Element("Value").Value, new NumberFormatInfo { NumberDecimalSeparator = "." });
                Currency key = (Currency)Enum.Parse(typeof(Currency), item.Attribute("Code").Value, ignoreCase: false);
                CurRates[key] = value;
            }
        }
    }

    [Serializable]
    class Account
    {
        private static int AccountCounter = 0;
        public Currency AccCurrency { get; set; }
        public int AccountID { get; }
        public string AccName { get; set; }
        public double Balance { get; set; }

        public Account(Currency accCurrency, string accName, double balance)
        {
            AccCurrency = accCurrency;
            AccName = accName;
            Balance = balance;
            AccountID = ++AccountCounter;
        }

        public override string ToString()
        {
            return AccName;
        }
    }

    [Serializable]
    class MoneFyFormsBuild
    {
        public delegate void StateHandler();

        public event StateHandler AccountsCountChanged;
        public event StateHandler OperationAdded;
        public event StateHandler BalanceChanged;

        public CurrencyRate CurRate { get; set; }
        public List<Account> Accounts { get; set; }
        public Languages Language { get; set; }
        public OperationType OperType { get; set; }
        public SortedList<DateTime, List<MoneyOperation>> Operations { get; private set; }
        public Dictionary<string, string> Categories { get; set; }
        public Dictionary<string, string> Interface { get; set; }
        public MoneFyFormsBuild(Languages lang)
        {
            Operations = new SortedList<DateTime, List<MoneyOperation>>();
            Accounts = new List<Account>();
            ChangeLang(lang);
            CurRate = new CurrencyRate();
        }
        public void ChangeLang(Languages lang)
        {
            Language = lang;
            Categories = MoneFeItemsLanguage.LoadCategories(lang);
            Interface = MoneFeItemsLanguage.LoadAppInterface(lang);
        }

        public void AddOperation(DateTime date, MoneyOperation operation)
        {
            if (Operations.ContainsKey(date))
                Operations[date].Add(operation);
            else
                Operations.Add(date, new List<MoneyOperation>{ operation });

            OperationAdded?.Invoke();
        }

        public void AddAccount(Account acc)
        {
            Accounts.Add(acc);
            AccountsCountChanged?.Invoke();
        }

        public void DeleteAccount(int id)
        {
            Accounts.RemoveAll(x => x.AccountID == id);
            AccountsCountChanged?.Invoke();
        }

        public void IncreaseBalanceToAccount(int id, double sum)
        {
            Accounts.Find(x => x.AccountID == id).Balance += sum;
            BalanceChanged?.Invoke();
        }

        public int GetLastAddedAccountID()
        {
            return Accounts[Accounts.Count - 1].AccountID;
        }

        public void ReduceAccountBalance(int id, double sum)
        {
            Accounts.Find(x => x.AccountID == id).Balance -= sum;
            BalanceChanged?.Invoke();
        }

        public void DeleteOperations(int id)
        {
            foreach (var item in Operations) { item.Value.RemoveAll(x => x.AccountID == id); }
            OperationAdded?.Invoke();
        }

        public void WriteToCSV(string path, int range)
        {
            var date = DateTime.Now;
            var list = Operations.Where(x => (date.Date - x.Key.Date).Days <= range).SelectMany(y => y.Value).ToList();
            string patch = path;
            try
            {
                File.WriteAllText(patch, $"{ Interface["account"]};{Interface["category"]};{Interface["summ"]};{Interface["currency"]};{Interface["comment"]}" + Environment.NewLine, Encoding.UTF8);
                foreach (var item in list)
                {
                    if (item.Type == OperationType.Account)
                        item.WriteCSV(patch, Interface[item.Category]);
                    else if (item.Type == OperationType.Category)
                        item.WriteCSV(patch, Categories[item.Category]);
                    else
                        item.WriteCSV(patch, Interface[item.Category]);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

