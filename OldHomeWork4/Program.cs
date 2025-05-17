using System;

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