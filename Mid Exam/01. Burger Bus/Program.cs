using System;
using System.Linq;

namespace _01._Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= cities; i++)
            {
                string name = Console.ReadLine();
                decimal money = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());
                if (i % 5 == 0 && i % 3 == 0)
                {
                    money -= money * 0.1m;
                }
                else if (i%5==0)
                {
                    money -= money * 0.1m;
                }
                else if(i%3==0 )
                {
                    expenses += expenses * 0.5m;
                }                
                
                decimal earn = Math.Round((money - expenses),2, MidpointRounding.AwayFromZero);
                sum += earn;

                Console.WriteLine($"In {name} Burger Bus earned {Math.Round(earn,2, MidpointRounding.AwayFromZero):f2} leva.");

            }
            Console.WriteLine($"Burger Bus total profit: {Math.Round(sum,2, MidpointRounding.AwayFromZero):f2} leva.");

        }
    }
}
