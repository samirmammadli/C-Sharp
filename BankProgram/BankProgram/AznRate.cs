// ReSharper disable PublicConstructorInAbstractClass
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable CollectionNeverQueried.Local
namespace BankProgram
{
    class AznRate
    {
        static public decimal USD { get; set; }
        static public decimal EUR { get; set; }

        static AznRate()
        {
            USD = 1.70m;
            EUR = 2.0024m;
        }

        static public decimal Convert(decimal sum, CURRENCY current, CURRENCY finalCurrency)
        {
            if (current == finalCurrency)
                return sum;

            if (current == CURRENCY.EUR)
                sum *= EUR;
            else if (current == CURRENCY.USD)
                sum *= USD;

            if (finalCurrency == CURRENCY.EUR)
                return sum / EUR;
            if (finalCurrency == CURRENCY.USD)
                return sum / USD;

            return sum;
        }
    }

}


