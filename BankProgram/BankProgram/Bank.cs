using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable PublicConstructorInAbstractClass
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable CollectionNeverQueried.Local
namespace BankProgram
{

     class AznRate
    {
        static public decimal USD { get; set; }
        static public decimal EUR { get; set; }

        static AznRate()
        {
            USD = 1.70m;
            EUR = 2.0024m;
        }

        static public decimal Convert(decimal sum, CURRENCY current, CURRENCY finalCurrency)
        {
            if (current == finalCurrency)
                return sum;

            if (current == CURRENCY.EUR)
                sum *= EUR;
            else if (current == CURRENCY.USD)
                sum *= USD;

            if (finalCurrency == CURRENCY.EUR)
                return sum / EUR;
            if (finalCurrency == CURRENCY.USD)
                return sum / USD;

            return sum;
        }
    }

    interface IAccount
    {
        bool Enabled { get; }
        CURRENCY Currency { get; }
        decimal Balance { get; }
        long Account { get; }
        long Id { get; }
        decimal Charge { get; }
        void Deposit(BaseClient sender, decimal sum, CURRENCY cur);
        void Withdraw(decimal sum, CURRENCY cur);
        void Transfer(BaseClient destAccount, decimal sum, CURRENCY cur);
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
        List<ITransaction> Transactions { get; set; }
        public BaseClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            Address = address;
            Currency = currency;
            Enabled = enabled;
            Transactions = new List<ITransaction>();
        }

        public bool Enabled { get; set; }
        public CURRENCY Currency { get; set; }
        public decimal Balance { get; set; }
        public long Account { get; set; }
        public decimal Charge { get; set; }
        public long Id { get; set; }
        public void Deposit(BaseClient sender, decimal sum, CURRENCY cur)
        {
            var temp = sum;
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, this.Currency, cur);
            this.Balance += sum;
            Transactions.Add(new DepositTrans(temp, cur, DateTime.Now, sender, this));
        }
        public void Withdraw(decimal sum, CURRENCY cur)
        {
            var temp = sum;
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, cur, this.Currency);

            sum +=  sum * Charge;

            if (Balance >= sum)
            {
                this.Balance -= sum;
                Transactions.Add(new WithdrawTran(temp, cur, DateTime.Now, this));
            }
            else
                throw new ArgumentException("Insufficient funds!");
        }

        public void Transfer(BaseClient destAccount, decimal sum, CURRENCY cur)
        {
            var temp = sum;
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            sum += sum * Charge;

            if (this.Balance >= sum)
                this.Balance -= sum;
            else
                throw new ArgumentException("Insufficient funds!");

            destAccount.Deposit(this, sum, cur);
            Transactions.Add(new TransferTran(temp, cur, DateTime.Now, this, destAccount));
        }
    }

    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name,  surname,  age,  phone,  address,  currency, enabled)
        { Charge = 0.3m; }
    }

    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name, surname, age, phone, address, currency, enabled)
        { Charge = 0.2m; }
}

    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled)
            : base(name, surname, age, phone, address, currency, enabled)
        { Charge = 0; }
    }


     class Bank
    {
        private List<BaseClient> _clients;
        public int ClientsCount { get; }

        public Bank()
        {
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


        public void AddNewClient (string name, string surname, int age, string phone, string address, CURRENCY currency, bool enabled, ClientMembership membership)
        { 
            if (membership == ClientMembership.Normal)
                _clients.Add(new Client(name, surname, age, phone, address, currency, enabled));
            else if (membership == ClientMembership.Gold)
                _clients.Add(new GoldenClient(name, surname, age, phone, address, currency, enabled));
            else
                _clients.Add(new PlatinumClient(name, surname, age, phone, address, currency, enabled));
        }
    }

}


