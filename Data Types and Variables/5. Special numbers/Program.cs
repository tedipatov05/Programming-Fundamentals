using System;

namespace _5._Special_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                bool special = false;
                int sum = 0;
                int digits = i;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }
                if (sum == 5 || sum == 7 || sum==11)
                {
                    special = true;                                     
                } 
                Console.WriteLine($"{i} -> {special}");

            }
        }
    }
}
