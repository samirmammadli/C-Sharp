using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

    interface ICSVWritable
    {
        void WriteCSV(string path, string category);
    }

    [Serializable]
    class MoneFyFormsBuild
    {
     
        public delegate void StateHandler();

        [field: NonSerialized]
        public event StateHandler AccountsCountChanged;
        [field: NonSerialized]
        public event StateHandler OperationAdded;
        [field: NonSerialized]
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

