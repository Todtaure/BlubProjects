using System;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace ConsoleTester
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Tester. Proceed as planned.\n");

            while (true)
            {
                ExtensionTest.Run(4,5);

                Console.WriteLine("To rerun, press enter.");
                Console.Write("> ");

                var userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.X)
                {
                    return;
                }
            }
        }
    }
}
