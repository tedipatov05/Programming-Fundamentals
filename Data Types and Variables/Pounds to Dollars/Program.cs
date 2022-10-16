using System;

namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal PoundsToDollarsExchangeRate = 1.31m;
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * PoundsToDollarsExchangeRate;
            Console.WriteLine($"{Math.Round(dolars, 3, MidpointRounding.AwayFromZero):F3}");
        }
    }
}
