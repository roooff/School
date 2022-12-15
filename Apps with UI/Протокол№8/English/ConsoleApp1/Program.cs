using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCount = 0;
            int mostFrequentNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = numbers.Length;
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentNum = numbers[i];
                }
            }
            Console.WriteLine(mostFrequentNum);
        }
    }
}
