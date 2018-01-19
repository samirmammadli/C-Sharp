using System;
using System.IO;
using System.Text;

namespace MoneFeWinForms
{
    [Serializable]
    class MoneyOperation : ICSVWritable
    {
        public Currency AccCurrency { get; }
        public string Category { get; }
        public string Account { get; }
        public OperationType Type { get; }
        public int AccountID { get; }
        public string Notes { get; }
        public double Value { get; }

        public MoneyOperation(Currency currency ,string category, string name, int accountID, string notes, double value, OperationType type = OperationType.Category)
        {
            AccCurrency = currency;
            Category = category;
            AccountID = accountID;
            Notes = notes;
            Value = value;
            Type = type;
            Account = name;
        }

        public void WriteCSV(string path, string category)
        {
            string csv = $"{Account};{category};{Value};{AccCurrency};{Notes}" + Environment.NewLine;
            try
            {
                File.AppendAllText(path, csv,Encoding.UTF8);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}