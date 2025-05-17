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