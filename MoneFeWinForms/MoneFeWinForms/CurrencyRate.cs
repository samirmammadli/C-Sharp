using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace MoneFeWinForms
{
    [Serializable]
    class CurrencyRate
    {
        public Dictionary<Currency, double> CurRates { get; set; }

        public CurrencyRate()
        {
            CurRates = new Dictionary<Currency, double> {
                {Currency.AZN, 1 },
                {Currency.USD, 1.701 },
                {Currency.EUR, 2.05 }
            };
        }

        public double EquateRates(Currency toThisCur, Currency cur, double sum)
        {
            if(toThisCur == cur) return sum;
            return Math.Round(sum * CurRates[cur] / CurRates[toThisCur],2);
        }

        public Dictionary<Currency, double> LoadRatesFromApi()
        {
            var responce = new Dictionary<Currency, double>();
            var date = DateTime.Now.ToString("dd.MM.yyyy");
            var link = $"https://www.cbar.az/currencies/{date}.xml";
            var rates = XDocument.Load(link);

            var result = from item in rates.Element("ValCurs").Elements("ValType").Elements("Valute")
                where item.Attribute("Code").Value == "EUR" || item.Attribute("Code").Value == "USD"
                select item;

            foreach (var item in result)
            {
                
                double value = Convert.ToDouble(item.Element("Value").Value, new NumberFormatInfo { NumberDecimalSeparator = "." });
                Currency key = (Currency)Enum.Parse(typeof(Currency), item.Attribute("Code").Value, ignoreCase: false);
                responce.Add(key, value);
            }

            return responce;
        }
    }
}