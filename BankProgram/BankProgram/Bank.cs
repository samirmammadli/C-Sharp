using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProgram
{
    interface IAccount
    {
        bool Enabled { get; }
        CURRENCY Currency { get; }
        decimal Balance { get; }
        long Account { get; }
        long UserID { get; }
        decimal Charge { get; }
        Transaction Deposit(decimal sum, CURRENCY cur);
        Transaction Withdraw(decimal sum, CURRENCY cur);
        Transaction Transfer(BaseClient destClient, decimal sum, CURRENCY cur);
    }

    abstract class Transaction
    {
        public readonly decimal _charge;
        public readonly bool _success;
        public readonly long _userId;
        public readonly decimal _amount;
        public readonly decimal _totalAmount;
        public readonly long account;
        public readonly CURRENCY _currency;
        public readonly CURRENCY _totalCur;
        public readonly DateTime _time;

        public Transaction(long id, decimal amount, decimal totalAmount, long account, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time,bool success)
        {
            _charge = charge;
            _success = success;
            _userId = id;
            _amount = amount;
            _totalAmount = totalAmount;
            this.account = account;
            _currency = currency;
            _totalCur = totalCur;
            _time = time;
        }
    }

    class DepositTrans : Transaction
    {
        public DepositTrans(long id, decimal amount, decimal totalAmount, long account, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { }
    }

    class TransferTran : Transaction
    {
        long _transferTo;
        public TransferTran(long id, decimal amount, decimal totalAmount, long account, long transferTo, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _transferTo = transferTo; }
    }

    class WithdrawTran : Transaction
    {
        public WithdrawTran(long id, decimal amount, decimal totalAmount, long account, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { }
    }

    [Serializable]
    abstract class Person
    {
        protected Person()
        {
            Name = "";
            Surname = "";
            Mail = "";
            Phone = "";
            Age = 0;
        }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    [Serializable]
    abstract class BaseClient : Person, IAccount
    {
        public BaseClient(string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled, decimal balance)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            Mail = mail;
            Currency = currency;
            Enabled = enabled;
            UserID = 0;
            Account = 0;
            if (balance > 0) Deposit(balance, currency);
        }

        public bool Enabled { get; set; }
        public CURRENCY Currency { get; set; }
        public decimal Balance { get; set; }
        public long Account { get; set; }
        public decimal Charge { get; set; }
        public long UserID { get; set; }
        private void Recieve(decimal sum, CURRENCY cur)
        {
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);
            this.Balance += sum;
        }
        public Transaction Deposit(decimal sum, CURRENCY cur)
        {
            var originalSum = sum;
            if (sum <= 0 || !Enabled)
            {
                throw new ArgumentException("Incorrect sum or account is disabled!");
            }
            if (this.Currency != cur)
               sum = AznRate.Convert(sum, cur, this.Currency);
            this.Balance += sum;
            return new DepositTrans(this.UserID, sum, originalSum, this.Account, 0, this.Currency, cur, DateTime.Now, true);
        }
        public Transaction Withdraw(decimal sum, CURRENCY cur)
        {
            var originalSum = sum;
            if (sum <= 0 || !Enabled)
            {
                throw new ArgumentException("Incorrect sum or account is disabled!");
            }
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            var charge = sum * this.Charge;
            sum +=  Charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
            {
                return new WithdrawTran(this.UserID, originalSum, originalSum, this.Account, 0, cur, cur, DateTime.Now, false);
            }

            return new WithdrawTran(this.UserID, sum, originalSum, this.Account, charge, this.Currency, cur, DateTime.Now, true);
        }
        public Transaction Transfer(BaseClient destClient, decimal sum, CURRENCY cur)
        {
            var originalSum = sum;
            if (sum <= 0 || !Enabled || !destClient.Enabled)
            {
                throw new ArgumentException("Incorrect sum or account is disabled!");
            }
            if (this.Currency != cur)
                sum = AznRate.Convert(sum, cur, this.Currency);

            var charge = sum * this.Charge;
            sum += Charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
            {
                return new TransferTran(this.UserID, originalSum, originalSum, this.Account, destClient.Account, 0, cur, cur, DateTime.Now, false);
            }
            destClient.Recieve(originalSum, cur);
            return new TransferTran(this.UserID, sum, originalSum, this.Account, destClient.Account, charge, this.Currency, cur, DateTime.Now, true);
        }
    }

    [Serializable]
    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled, decimal balance)
            : base(name,  surname,  age,  phone,  mail,  currency, enabled, balance)
        { Charge = 0.3m; }
    }

    [Serializable]
    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled, decimal balance)
            : base(name,  surname,  age,  phone,  mail,  currency, enabled, balance)
        { Charge = 0.2m; }
    }

    [Serializable]
    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled, decimal balance)
            : base(name,  surname,  age,  phone,  mail,  currency, enabled, balance)
        { Charge = 0; }
    }


    static class EnumConverter
    {
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


    static class SaveLoadData
    {
        static public List<T> LoadData<T>(string path)
        {
            if (File.Exists(path))
            {
                var formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    if (fs.Length > 0)
                    {
                        try
                        {
                            return formatter.Deserialize(fs) as List<T>;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                }
                return new List<T>();
            }
            
                return new List<T>();
        }

        static public void SaveData<T>(List<T> list, string path)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }

    class Bank
    {
        private long IdCounter;
        private long AccountNumber;
        private List<Transaction> _transactions;
        private List<BaseClient> _clients;

        public Bank()
        {
            _transactions = new List<Transaction>();
            LoadData();
            if (_clients.Count > 0 )
            {
                IdCounter = _clients[_clients.Count - 1].UserID;
                AccountNumber = _clients[_clients.Count - 1].Account + 1;
            }
            else
            {
                IdCounter = 0;
                AccountNumber = 8713154200000001;
            }
        }
        public void LoadData()
        {
            try
            {
                _clients = SaveLoadData.LoadData<BaseClient>("clients.dat");
            }
            catch (Exception e)
            {
                _clients = new List<BaseClient>();
                MessageBox.Show(e.Message);
            }
        }

        public void SaveData()
        {
            try
            {
                SaveLoadData.SaveData(_clients, "clients.dat");
            }
            catch (Exception e)
            {
                _clients = new List<BaseClient>();
            }
            
        }

        private void SetID(BaseClient client)
        {
            if (client.UserID == 0)
                client.UserID = ++IdCounter;
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

        public void CheckUserRegData(string name, string surname, int age, string phone, string mail, CURRENCY currency,  ClientMembership membership)
        {
            Regex[] regex = new Regex[6];
            regex[0] = new Regex(@"^[A-z]{1,30}$");
            regex[1] = new Regex(@"^[+]994[55|50|51|70|77]{2}[0-9]{7}$");
            regex[2] = new Regex(@"^[a-z,0-9,_,-]{1,30}@[a-z,0-9,_,-,.]{1,20}[a-z,0-9,_,-,.]{1,20}.[a-z]{2,5}$", RegexOptions.IgnoreCase);
            regex[3] = new Regex(@"^[AZN|USD|EUR]{3}$");
            regex[4] = new Regex(@"^[Gold|Normal|Platinum]{4,8}$");

            if (!regex[0].IsMatch(name)) throw new ArgumentException("Wrong name!");
            if (!regex[0].IsMatch(surname)) throw new ArgumentException("Wrong surname!");
            if (!(Convert.ToInt32(age) > 18 && Convert.ToInt32(age) < 100)) throw new ArgumentException("Wrong age!");
            if (!regex[2].IsMatch(mail)) throw new ArgumentException("Wrong mail!");
            if (!regex[1].IsMatch(phone)) throw new ArgumentException("Wrong phone!");
            if (!regex[3].IsMatch(currency.ToString())) throw new ArgumentException("Wrong currency!");
            if (!regex[4].IsMatch(membership.ToString())) throw new ArgumentException("Wrong membership!");
        }

        public void AddNewClient (string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled, ClientMembership membership, decimal balance = 0)
        {
            try
            {
                CheckUserRegData(name, surname, age, phone, mail, currency, membership);
            }
            catch (Exception e)
            {

                throw e;
            }
            if (membership == ClientMembership.Platinum)
                _clients.Add(new PlatinumClient(name, surname, age, phone, mail, currency, enabled, balance));
            else if (membership == ClientMembership.Gold)
                _clients.Add(new GoldenClient(name, surname, age, phone, mail, currency, enabled, balance));
            else
                _clients.Add(new Client(name, surname, age, phone, mail, currency, enabled, balance));

            SetID(_clients[_clients.Count - 1]);
            SetAccount(_clients[_clients.Count - 1]);
        }

        public void Deposit(BaseClient client, decimal sum, CURRENCY cur)
        {
            try
            {
                _transactions.Add(client.Deposit(sum, cur));
            }
            catch (Exception e) { throw e; } 
        }

        public void Withdraw(BaseClient client, decimal sum, CURRENCY cur)
        {
            try
            {
                _transactions.Add(client.Withdraw(sum, cur));
            }
            catch (Exception e) { throw e; }
        }

        public void Transfer(BaseClient from, BaseClient to, decimal sum, CURRENCY cur)
        {
            try
            {
                _transactions.Add(from.Withdraw(sum, cur));
            }
            catch (Exception e) { throw e; }
        }

        public List<BaseClient> SearchClients(string id, string account, string name, string surname, string balance)
        {
            var users = (from client in _clients
                         where client.UserID.ToString().Contains(id)
                         where client.Account.ToString().Contains(account)
                         where new Regex(name, RegexOptions.IgnoreCase).IsMatch(client.Name)
                         where new Regex(surname, RegexOptions.IgnoreCase).IsMatch(client.Surname)
                         where client.Surname.Contains(surname)
                         where client.Balance.ToString().Contains(balance)
                         select client).ToList();
            return users;
        }
    }

}


