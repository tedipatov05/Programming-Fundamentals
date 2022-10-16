using System;

namespace _1._Integer_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int result = (num1 + num2) / num3;
            Console.WriteLine(result*num4);
        }
    }
}
