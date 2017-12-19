using System;

namespace BankProgram
{
    [Serializable]
    class WithdrawTran : Transaction
    {
        public WithdrawTran(long id, decimal amount, decimal totalAmount, long account, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _type = TransactionType.Withdraw;}
    }
}