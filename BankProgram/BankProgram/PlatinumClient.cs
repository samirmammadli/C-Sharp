using System;

namespace BankProgram
{
    [Serializable]
    class PlatinumClient : BaseClient
    {
        public PlatinumClient(string name, string surname, int age, string phone, string mail, CURRENCY currency,
            bool enabled, decimal balance)
            : base(name, surname, age, phone, mail, currency, enabled, balance)
        { base.Charge = 0.01m; }
    }
}