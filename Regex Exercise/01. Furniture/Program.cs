using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";
            string input = Console.ReadLine();
            var items = new List<string>();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                MatchCollection matched = Regex.Matches(input, pattern);
                foreach (Match match in matched)
                {
                    var name = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quant = int.Parse(match.Groups["quant"].Value);
                    items.Add(name);
                    totalPrice += price * quant;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:{Environment.NewLine}{string.Join(Environment.NewLine, items)}");
            Console.WriteLine($"Total money spend: {totalPrice:F2}");



        }
    }
}
