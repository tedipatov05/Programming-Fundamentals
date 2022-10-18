using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Fact1(num1)/Fact1(num2):f2}");
        }
        static decimal Fact1(int num1)
        {
            decimal fact = 1;
            for (int i = 1; i <= num1; i++)
            {
                fact *= i;

            }
            return fact;
        }
        
    }
}
