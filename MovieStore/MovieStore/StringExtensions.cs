using System;

namespace MovieStore
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, 0, comp) == 0;
        }
    }
}
