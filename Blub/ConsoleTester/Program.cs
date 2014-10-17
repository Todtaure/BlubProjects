using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = "";
            Console.WriteLine("Console Tester. Proceed as planned.\n");

            while (userInput != "exit")
            {
                Console.WriteLine("Add: " + Add(5.5,10));
                Console.WriteLine("Subtract: " + Subtract(20, 5.55));
                Console.WriteLine("Multiply: " + Multiply(2, 6.6));

                var testCalc = CreateCalculator(15, 6.15);
                Console.WriteLine("Calculator Class add: " + CalculatorAdd(testCalc));
                DisposeCalculator(testCalc);

                Console.Write("> ");
                userInput = Console.ReadLine();
            }
        }

        #region dll Imports

        //Single Methods
        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Subtract(double a, double b);

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Multiply(double a, double b);

        //Class methods
        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateCalculator(double x, double y);

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeCalculator(IntPtr ptr);

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double CalculatorAdd(IntPtr ptr);

        #endregion dll Imports
    }

}
