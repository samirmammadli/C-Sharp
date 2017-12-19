namespace BankProgram
{
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
}