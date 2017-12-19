using System;

namespace BankProgram
{
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
}