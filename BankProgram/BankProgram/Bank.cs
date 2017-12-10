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
        public decimal USD { get; set; }
        public decimal EUR { get; set; }

        public AznRate(decimal usd, decimal eur)
        {
            USD = usd;
            EUR = eur;
        }

        public decimal Convert(decimal sum, CURRENCY current, CURRENCY destination)
        {
            if (current == destination)
                return sum;

            if (current == CURRENCY.EUR)
                sum *= EUR;
            else if (current == CURRENCY.USD)
                sum *= USD;

            if (destination == CURRENCY.EUR)
                return sum / EUR;
            if (destination == CURRENCY.USD)
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
        void CashIn();
        void Withdraw();
        void Transfer();
    }

    interface ITransaction
    {
        long Amount { get; }
        DateTime Time { get; }
    }

    class CashInTran : ITransaction
    {
        public long Amount { get; set; }
        public DateTime Time { get; set; }
        public void To(BaseClient client) { }
    }

    class TransferTran : ITransaction
    {
        public long Amount { get; set; }
        public DateTime Time { get; set; }
        public void From(BaseClient client) { }
    }

    class WithdrawTran : ITransaction
    {
        public long Amount { get; set; }
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
        public long Id { get; set; }
        public void CashIn() { }
        public void Withdraw() { }
        public void Transfer() { }
    }

    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency) { }
    }

    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency) { }
    }

    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string address, CURRENCY currency) : base(name,  surname,  age,  phone,  address,  currency) { }
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


