using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PowerNum(num, power);
            Console.WriteLine(result);
        }
        static double PowerNum(double num, int power)
        {
            double result = 1;

            for(int i=1;i<=power;i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
