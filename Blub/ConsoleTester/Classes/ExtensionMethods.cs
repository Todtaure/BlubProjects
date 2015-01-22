using System;
using System.Text.RegularExpressions;

namespace ConsoleTester.Classes
{
    public static class ExtensionTest
    {
        public static void Run(int left, int right, string value)
        {
            Console.Write("Using extension methods; is {0} less than {1}? ", left, right);
            Console.Write(left.IsLessThan(right));

            Console.Write("\n\nUsing extension methods; what is the punctuation count of '{0}', not counting dots: ", value);
            Console.Write(value.PunctuationCount() + "\n");
        }
    }

    public static class ExtensionMethods
    {
        public static bool IsLessThan(this int left, int right)
        {
            return left < right;
        }

        public static int PunctuationCount(this string value)
        {
            return Regex.Matches(value, @"[^\w\s\\\.]").Count;
        }
    }
}
