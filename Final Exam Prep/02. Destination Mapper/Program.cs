using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int points = 0;
            List<string> results = new List<string>();

            string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
              
            foreach (Match match in matches)
            {
                results.Add(match.Groups["destination"].Value);
                points += match.Groups["destination"].Value.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",results)}");
            Console.WriteLine($"Travel Points: {points}");
            

        }
    }
}
