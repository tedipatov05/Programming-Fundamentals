using System;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNumberSign(num);
        }
        static void PrintNumberSign(int number)
        {
            if(number>0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if(number<0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
