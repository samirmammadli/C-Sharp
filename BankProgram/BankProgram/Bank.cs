using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Globalization;
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

    [Serializable]
    abstract class Transaction
    {
        public TransactionType _type;
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
            : base (id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _type = TransactionType.Deposit; }
    }
    [Serializable]
    class TransferTran : Transaction
    {
       public readonly string _transferTo;
        public TransferTran(long id, decimal amount, decimal totalAmount, long account, long transferTo, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _transferTo = transferTo.ToString(); _type = TransactionType.Transfer; }
    }
    [Serializable]
    class WithdrawTran : Transaction
    {
        public WithdrawTran(long id, decimal amount, decimal totalAmount, long account, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _type = TransactionType.Withdraw;}
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
        //public void Recieve(decimal sum, CURRENCY cur)
        //{
        //    if (this.Currency != cur)
        //        sum = AznRate.Convert(sum, cur, this.Currency);
        //    this.Balance += sum;
        //}
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
            return new DepositTrans(this.UserID, originalSum, sum, this.Account, 0, cur, this.Currency, DateTime.Now, true);
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
            sum += charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
            {
                throw new ArgumentException("Insufficient funds!");
            }

            return new WithdrawTran(this.UserID, originalSum, sum, this.Account, charge, cur, this.Currency, DateTime.Now, true);
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
            sum += charge;

            if (Balance >= sum)
                this.Balance -= sum;
            else
            {
                throw new ArgumentException("Insufficient funds!");
            }
            return new TransferTran(this.UserID, originalSum, sum, this.Account, destClient.Account, charge,  cur, this.Currency, DateTime.Now, true);
        }
    }

    [Serializable]
    class Client : BaseClient
    {
        public Client(string name, string surname, int age, string phone, string mail, CURRENCY currency, bool enabled,
            decimal balance)
            : base(name, surname, age, phone, mail, currency, enabled, balance)
        { base.Charge = 0.04m; }
    }

    [Serializable]
    class GoldenClient : BaseClient
    {
        public GoldenClient(string name, string surname, int age, string phone, string mail, CURRENCY currency,
            bool enabled, decimal balance)
            : base(name, surname, age, phone, mail, currency, enabled, balance)
        {base.Charge = 0.02m; }
    }

    [Serializable]
    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string mail, CURRENCY currency,
            bool enabled, decimal balance)
            : base(name, surname, age, phone, mail, currency, enabled, balance)
        { base.Charge = 0.01m; }
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
        private long _idCounter;
        private long _accountNumber;
        private List<Transaction> _transactions;
        private List<BaseClient> _clients;

        public Bank()
        {
            LoadData();
            if (_clients.Count > 0 )
            {
                _idCounter = _clients[_clients.Count - 1].UserID;
                _accountNumber = _clients[_clients.Count - 1].Account + 1;
            }
            else
            {
                _idCounter = 0;
                _accountNumber = 8713154200000001;
            }
        }

        private void LoadData()
        {
            try
            {
                _transactions = SaveLoadData.LoadData<Transaction>("transactions.dat");
                _clients = SaveLoadData.LoadData<BaseClient>("clients.dat");
            }
            catch (Exception e)
            {
                _transactions = new List<Transaction>();
                _clients = new List<BaseClient>();
            }
        }

        public void SaveClients()
        {
            try
            {
                SaveLoadData.SaveData(_clients, "clients.dat");
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public void SaveTransactions()
        {
            try
            {
                SaveLoadData.SaveData(_transactions, "transactions.dat");
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void SetID(BaseClient client)
        {
            if (client.UserID == 0)
                client.UserID = ++_idCounter;
            else
                throw new ArgumentException("Client alrady have an ID!");
        }
        private void SetAccount(BaseClient client)
        {
            if (client.Account == 0)
                client.Account = _accountNumber++;
            else
                throw new ArgumentException("Client alrady have and account!");
        }

        private void CheckUserRegData(string name, string surname, int age, string phone, string mail, ClientMembership membership, CURRENCY currency)
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
                CheckUserRegData(name, surname, age, phone, mail, membership, currency);
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

        public void Deposit(string acc, decimal sum, CURRENCY cur)
        {
            try
            {
                var client = FindClient(acc);
                _transactions.Add(client.Deposit(sum, cur));
            }
            catch (Exception e) { throw e; } 
        }

        public void Withdraw(string acc, decimal sum, CURRENCY cur)
        {
            try
            {
                var client = FindClient(acc);
                _transactions.Add(client.Withdraw(sum, cur));
            }
            catch (Exception e) { throw e; }
        }

        public void Transfer(string fromAcc, string toAcc, decimal sum, CURRENCY cur)
        {
            if (fromAcc == toAcc)
                throw new ArgumentException("Can not be transferred to the same account!");
            try
            {
                var from = FindClient(fromAcc);
                var to = FindClient(toAcc);
                _transactions.Add(from.Transfer(to,sum, cur));
                _transactions.Add(to.Deposit(sum, cur));
                MessageBox.Show(_transactions.Count.ToString());
            }
            catch (Exception e) { throw e; }
        }


        public BaseClient FindClient(string account)
        {
            for (int i = 0; i < _clients.Count; i++)
            {
                if (_clients[i].Account.ToString() == account)
                    return _clients[i];
            }
            throw new ArgumentException("Account not found!");
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

        public List<Transaction> SearcTransactions(DateTime start, DateTime end, string account, string id, TransactionType? type = null)
        {
            var transactions = (from item in _transactions
                                where item._type == type || type == null
                                where item._time.Date >= start && item._time.Date <= end
                                where item._userId.ToString().Contains(id)
                                where item.account.ToString().Contains(account)
                                select item).ToList();
            return transactions;
        }
        public void EditClient(long id, string name, string surname, string mail, string phone,int age, bool enabled)
        {
            BaseClient client = null;
            for (int i = 0; i < _clients.Count; i++)
            {
                if (id == _clients[i].UserID)
                {
                    client = _clients[i];
                    break;
                } 
            }
            if (client == null)
                throw new ArgumentException("Client with this ID not found!");
            try
            {
                CheckUserRegData(name, surname, age, phone, mail, ClientMembership.Normal, CURRENCY.AZN);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            client.Name = name;
            client.Surname = surname;
            client.Age = age;
            client.Mail = mail;
            client.Phone = phone;
            client.Enabled = enabled;
        }
    }
}


