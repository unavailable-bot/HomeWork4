using System;

namespace OldHomeWork4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1();
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