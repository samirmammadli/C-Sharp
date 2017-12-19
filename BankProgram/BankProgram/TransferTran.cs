using System;

namespace BankProgram
{
    [Serializable]
    class TransferTran : Transaction
    {
        public readonly string _transferTo;
        public TransferTran(long id, decimal amount, decimal totalAmount, long account, long transferTo, decimal charge, CURRENCY currency, CURRENCY totalCur, DateTime time, bool success)
            : base(id, amount, totalAmount, account, charge, currency, totalCur, time, success) { _transferTo = transferTo.ToString(); _type = TransactionType.Transfer; }
    }
}