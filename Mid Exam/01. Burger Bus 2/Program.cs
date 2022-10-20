using System;

namespace _01._Burger_Bus_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;
            for(int i = 1; i <= cities; i++)
            {
                string name = Console.ReadLine();
                decimal earnedMoney =  decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());  
                
                if(i%3==0 )
                {
                    if (i % 5 == 0)
                    {
                        earnedMoney -= earnedMoney * 0.1m;
                    }
                    else
                    {
                        expenses += expenses * 0.5m;

                    }
                    
                }
                else if(i%5==0)
                {
                    earnedMoney -= earnedMoney * 0.1m;
                }
                decimal profit = earnedMoney - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {name} Burger Bus earned {profit:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
       
    }
}
