using System;

namespace MoneFeWinForms
{
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
}