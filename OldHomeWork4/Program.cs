using System;

namespace OldHomeWork4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task4();
        }

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