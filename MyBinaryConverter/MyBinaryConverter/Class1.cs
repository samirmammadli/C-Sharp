namespace MyBinaryConverter
{
    static public class BinaryConverter 
    {
        static private string result;
        static public string ConvertToBinary(int number)
        {
            if (number == 0) return "0";
            if (number < 0) result = "-";
            return GetBinaryCode(number);
        }
        static private string GetBinaryCode(int number)
        {
            if (number == 0) return result;
            string temp;
            if (number % 2 != 0) temp = "1";
            else temp = "0";
            GetBinaryCode(number /= 2);
            result += temp;
            return result;
        }
    }
}

