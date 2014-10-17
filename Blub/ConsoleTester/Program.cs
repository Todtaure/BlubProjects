using System;
using System.Runtime.InteropServices;


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

                var testCalc = CreateCalculator();
                Console.WriteLine("Calculator Class add: " + CalculatorAdd(testCalc, 15, 6.15));
                DisposeCalculator(testCalc);
                testCalc = IntPtr.Zero;

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
        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateCalculator();

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeCalculator(IntPtr ptr);

        [DllImport("MathFuncDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double CalculatorAdd(IntPtr ptr, double x, double y);

        #endregion dll Imports
    }

}
