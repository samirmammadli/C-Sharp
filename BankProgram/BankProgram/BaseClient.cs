using System;

namespace BankProgram
{
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
}