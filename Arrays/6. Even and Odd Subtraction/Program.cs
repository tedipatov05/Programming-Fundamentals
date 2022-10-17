using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            foreach(int num in numbers)
            {
                if(num%2==0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }

            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
