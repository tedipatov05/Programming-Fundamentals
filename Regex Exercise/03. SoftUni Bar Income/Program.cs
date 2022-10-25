using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double totalIncome = 0;

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(line, pattern))
                {
                    Match match = Regex.Match(line, pattern);
                    var customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncome += money;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
