using System;
using ConsoleTester.Classes;

namespace ConsoleTester
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Tester. Proceed as planned.\n");

            while (true)
            {
                ExtensionTest.Run(4,5, "This is a test sentence, containing some´ different symbols: like a . or a / and ?.");

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
