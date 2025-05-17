using System;
using System.Threading.Tasks;

namespace OldHomeWork4
{
    internal class Program
    {
        private static Random _rand = new Random();
        private static string result = "It's ";
        private static int evenNumbers;

        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        private static void Task1()
        {
            try
            {
                int[] array = new int[50];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0)
                    {
                        array[i] += 2;
                        continue;
                    }

                    array[i] += array[i - 1] + 2;
                }

                foreach (var value in array)
                {
                    ResultMessage($"Element: {value}");
                }
            }
            catch (Exception e)
            {
                ResultMessage($"Error: {e.Message}");
            }
        }

        private static void Task2()
        {
            try
            {
                int[] array = new int[_rand.Next(24, 51)];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = _rand.Next(0, int.MaxValue);
                    if (array[i] % 2 == 0)
                    {
                        evenNumbers++;
                        result += $"{array[i]}, ";
                    }
                }

                ResultMessage($"Even numbers count: {evenNumbers}\n{result}");
            }
            catch (Exception e)
            {
                ResultMessage($"Error: {e.Message}");
            }
        }

        #region FullTask3

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
                if (char.ToLower(inputSymbol.KeyChar) == character ||
                    char.ToUpper(inputSymbol.KeyChar) == character)
                {
                    inputSymbolCount++;
                }
            }

            ResultMessage($"\nCount of {inputSymbol.KeyChar} is {inputSymbolCount}");
        }

        #endregion
        
        private static void Task4()
        {
            try
            {
                char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

                for (int i = 0; i < alphabet.Length; i++)
                {
                    ResultMessage($"{alphabet[i]} -> {(byte)alphabet[i]}");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                ResultMessage($"Error: {e.Message}");
            }
        }
        
        private static void ResultMessage(string message)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(message);
        }
    }
}