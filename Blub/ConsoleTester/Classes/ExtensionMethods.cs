using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    public static class RunExtensionTest
    {
        public static void Run(int left, int right)
        {
            Console.WriteLine("Using extension methods; is {0} less than {1}", left, right);
            Console.WriteLine(left.IsLessThan(right));
        }
    }

    public static class ExtensionMethods
    {
        public static bool IsLessThan(this int left, int right)
        {
            return left < right;
        }
    }
}
