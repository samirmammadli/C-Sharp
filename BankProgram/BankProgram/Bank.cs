using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
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
        CURRENCY Currency { get; }
        decimal Balance { get; }
        long Account { get; }
        long Id { get; }
        decimal Charge { get; }
        void CashIn(decimal sum, CURRENCY cur);
        void Withdraw(decimal sum, CURRENCY cur);
        void Transfer(long destAccount, decimal sum, CURRENCY cur);
    }

    interface ITransaction
    {
        decimal Amount { get; }
        CURRENCY Currency { get; }
        DateTime Time { get; }
    }

    class CashInTran : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }
        public void To(BaseClient client) { }
    }

    class TransferTran : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }
        public void FromTo(BaseClient client) { }
    }

    class WithdrawTran : ITransaction
    {
        public decimal Amount { get; set; }
        public CURRENCY Currency { get; set; }
        public DateTime Time { get; set; }
        public void From(BaseClient client) { }
    }

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


    abstract class BaseClient : Person, IAccount
    {
        public BaseClient(string name, string surname, int age, string phone, string address, CURRENCY currency)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            Address = address;
            Currency = currency;
        }
        public CURRENCY Currency { get; set; }
        public decimal Balance { get; set; }
        public long Account { get; set; }
        public decimal Charge { get; set; }
        public long Id { get; set; }
        public void CashIn(decimal sum, CURRENCY cur)
        {
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, this.Currency, cur);
            this.Balance += sum;
        }
        public void Withdraw(decimal sum, CURRENCY cur)
        {
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, cur, this.Currency);

            sum +=  sum * Charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
                throw new ArgumentException("Insufficient funds!");
        }
        public void Transfer(long destAccount, decimal sum, CURRENCY cur)
        {
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            sum += sum * Charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
                throw new ArgumentException("Insufficient funds!");
        }
    }

    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency)
        { Charge = 0.3m; }
    }

    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency)
        { Charge = 0.2m; }
}

    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency)
        { Charge = 0; }
    }


     class Bank
    {
        private List<BaseClient> _clients;
        private AznRate _rate;
        public int ClientsCount { get; }

        public Bank(AznRate rate)
        {
            _rate = rate;
            _clients = new List<BaseClient>();
            ClientsCount = 0;
        }

        public void AddNewClient (string name, string surname, int age, string phone, string address, CURRENCY currency, ClientMembership membership)
        {   
            if (membership == ClientMembership.Normal)
                _clients.Add(new Client(name, surname, age, phone, address, currency));
            else if (membership == ClientMembership.Gold)
                _clients.Add(new GoldenClient(name, surname, age, phone, address, currency));
            else
                _clients.Add(new PlatinumClient(name, surname, age, phone, address, currency));
        }
    }

}


