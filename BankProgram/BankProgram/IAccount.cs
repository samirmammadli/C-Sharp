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
}