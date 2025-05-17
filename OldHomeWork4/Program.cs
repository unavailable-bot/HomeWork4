using System;
using System.Threading.Tasks;

namespace OldHomeWork4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task3();
        }

        private static void Task3()
        {
            try
            {
                string inputString = Console.ReadLine();
                ResultMessage($"Count of chars: {inputString?.Length}");
                
                Task3dot1(inputString);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                ResultMessage($"Error: {e.Message}");
            }
        }

        private static void Task3dot1(string inputString)
        {
            Console.WriteLine("Which symbol do you want to find?");
            ConsoleKeyInfo inputSymbol = Console.ReadKey();
            int inputSymbolCount = 0;
            foreach (var character in inputString)
            {
                if (char.ToLower(inputSymbol.KeyChar) == character || char.ToUpper(inputSymbol.KeyChar) == character)
                {
                    inputSymbolCount++;
                }
            }
            ResultMessage($"\nCount of {inputSymbol.KeyChar} is {inputSymbolCount}");
        }

        private static void ResultMessage(string message)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(message);
        }
    }
}