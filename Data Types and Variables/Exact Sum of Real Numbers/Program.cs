using System;

namespace Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for(int i=0;i<n;i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;

            }
            Console.WriteLine(sum);
        }
    }
}
