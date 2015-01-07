using System;
using System.Runtime.InteropServices;
using NLog;


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
                RunExtensionTest.Run(4,5);

                Console.WriteLine("To rerun, press enter.");
                Console.Write("> ");
                userInput = Console.ReadLine();
            }
        }
       
    }

}
