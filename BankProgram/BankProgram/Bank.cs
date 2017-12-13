using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace BankProgram
{
    interface IAccount
    {
        bool Enabled { get; }
        CURRENCY Currency { get; }
        decimal Balance { get; }
        long Account { get; }
        long Id { get; }
        decimal Charge { get; }
        decimal Deposit(BaseClient sender, decimal sum, CURRENCY cur);
        decimal Withdraw(decimal sum, CURRENCY cur);
        decimal Transfer(BaseClient destAccount, decimal sum, CURRENCY cur);
    }

    interface ITransaction
    {
        decimal Amount { get; }
        long ToAccount { get; }
        CURRENCY Currency { get; }
        DateTime Time { get; }
    }

    class DepositTrans : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }

        public long FromAccount { get; set; }
        public long ToAccount { get; set; }

        public DepositTrans(decimal amount, CURRENCY currency, DateTime time, BaseClient from, BaseClient to)
        {
            Amount = amount;
            Currency = currency;
            Time = time;
            FromAccount = from.Account;
            ToAccount = to.Account;
        }
    }

    class TransferTran : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }
        public long FromAccount { get; set; }
        public long ToAccount { get; set; }

        public TransferTran(decimal amount, CURRENCY currency, DateTime time, BaseClient from, BaseClient to)
        {
            Amount = amount;
            Currency = currency;
            Time = time;
            FromAccount = from.Account;
            ToAccount = to.Account;
        }
    }

    class WithdrawTran : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }
        public long ToAccount { get; set; }

        public WithdrawTran(decimal amount, CURRENCY currency, DateTime time, BaseClient to)
        {
            Amount = amount;
            Currency = currency;
            Time = time;
            ToAccount = to.Account;
        }
    }
    [Serializable]
    abstract class Person
    {
        protected Person()
        {
            Name = "";
            Surname = "";
            Address = "";
            Phone = "";
            Age = 0;
        }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    [Serializable]
    abstract class BaseClient : Person, IAccount
    {
        public BaseClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            Address = address;
            Currency = currency;
            Enabled = enabled;
            Id = 0;
            Account = 0;
        }

        public bool Enabled { get; set; }
        public CURRENCY Currency { get; set; }
        public decimal Balance { get; set; }
        public long Account { get; set; }
        public decimal Charge { get; set; }
        public long Id { get; set; }
        public decimal Deposit(BaseClient sender, decimal sum, CURRENCY cur)
        {
            if (sum <= 0)
                throw new ArgumentException("Incorrect sum!");
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, cur, this.Currency);
            this.Balance += sum;
            return sum;
        }
        public decimal Withdraw(decimal sum, CURRENCY cur)
        {
            if (sum <= 0)
                throw new ArgumentException("Incorrect sum!");
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            sum +=  sum * this.Charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
                throw new ArgumentException("Insufficient funds!");

            return sum;
        }

        public decimal Transfer(BaseClient destAccount, decimal sum, CURRENCY cur)
        {
            var sumInOriginalCurrency = sum;
            if (sum <= 0)
                throw new ArgumentException("Incorrect sum!");
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            sum += sum * Charge;

            if (this.Balance >= sum)
                this.Balance -= sum;
            else
                throw new ArgumentException("Insufficient funds!");

            destAccount.Deposit(this, sumInOriginalCurrency, cur);
            return sum;
        }
    }

    [Serializable]
    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name,  surname,  age,  phone,  address,  currency, enabled)
        { Charge = 0.3m; }
    }

    [Serializable]
    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name, surname, age, phone, address, currency, enabled)
        { Charge = 0.2m; }
    }

    [Serializable]
    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name, surname, age, phone, address, currency, enabled)
        { Charge = 0; }
    }


    static class EnumConverter
    {
        static public string CurrencyToString(CURRENCY cur)
        {
            string Cur = "AZN";
            if (cur == CURRENCY.EUR)
                Cur = "EUR";
            else if (cur == CURRENCY.USD)
                Cur = "USD";

            return Cur;
        }

        static public CURRENCY StringToCurrency(string cur)
        {
            CURRENCY Cur = CURRENCY.AZN;
            if (cur == "USD")
                Cur = CURRENCY.USD;
            else if (cur == "EUR")
                Cur = CURRENCY.EUR;

            return Cur;
        }
    }

    class Bank
    {
        private long IdCounter = 0;
        private long AccountNumber = 8713154200000001;
        private SortedList<long, ITransaction> _transactions;
        private List<BaseClient> _clients;
        public int ClientsCount { get; }

        public Bank()
        {
            _transactions = new SortedList<long, ITransaction>();
            LoadData();
            ClientsCount = 0;
        }
        public void LoadData()
        {
            if (File.Exists("clients.dat"))
            {
                var formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
                {
                     if (fs.Length > 0)
                    _clients = (List<BaseClient>)formatter.Deserialize(fs);
                }
            }
            else
               _clients = new List<BaseClient>();
        }

        public void SaveData()
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _clients);
            }
        }

        private void SetID(BaseClient client)
        {
            if (client.Id == 0)
                client.Id = ++IdCounter;
            else
                throw new ArgumentException("Client alrady have an ID!");
        }
        private void SetAccount(BaseClient client)
        {
            if (client.Account == 0)
                client.Account = AccountNumber++;
            else
                throw new ArgumentException("Client alrady have and account!");
        }

        public void AddNewClient (string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled, ClientMembership membership)
        { 
            if (membership == ClientMembership.Normal)
                _clients.Add(new Client(name, surname, age, phone, address, currency, enabled));
            else if (membership == ClientMembership.Gold)
                _clients.Add(new GoldenClient(name, surname, age, phone, address, currency, enabled));
            else
                _clients.Add(new PlatinumClient(name, surname, age, phone, address, currency, enabled));

            SetID(_clients[_clients.Count - 1]);
            SetAccount(_clients[_clients.Count - 1]);
        }

        public void Deposit(BaseClient client, decimal sum, CURRENCY cur)
        {
            try
            {
                client.Deposit(client, sum, cur);
                _transactions.Add(client.Id, new DepositTrans(sum, cur, DateTime.Now, client, client));
            }
            catch (Exception e) { throw e; } 
        }

        public void Withdraw(BaseClient client, decimal sum, CURRENCY cur)
        {
            try
            {
                client.Withdraw(sum, cur);
                _transactions.Add(client.Id, new WithdrawTran(sum, cur, DateTime.Now, client));
            }
            catch (Exception e) { throw e; }
        }

        public void Transfer(BaseClient from, BaseClient to, decimal sum, CURRENCY cur)
        {
            try
            {
                from.Withdraw(sum, cur);
                //_transactions.Add(client.Id, new WithdrawTran(sum, cur, DateTime.Now, client));
            }
            catch (Exception e) { throw e; }
        }

        public ArrayList[] GetUsersData()
        {
            ArrayList[] list = new ArrayList[_clients.Count];
            for (int i = 0; i < _clients.Count; i++)
            {
                list[i] = new ArrayList();
                list[i].Add(_clients[i].Id);
                list[i].Add(_clients[i].Account);
                list[i].Add(_clients[i].Name);
                list[i].Add(_clients[i].Surname);
                list[i].Add(_clients[i].Phone);
                list[i].Add(_clients[i].Address);
                list[i].Add(_clients[i].Balance);
                list[i].Add(EnumConverter.CurrencyToString(_clients[i].Currency));
                list[i].Add(_clients[i].Enabled);
            }
            return list;
        }
    }

}


