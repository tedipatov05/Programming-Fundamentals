using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();

            string[] players = Console.ReadLine()
                .Split(", ");

            foreach (string player in players)
            {
                if (!dict.ContainsKey(player))
                {
                    dict[player] = 0;
                }
            }

            while (true)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                double distance = 0;

                if (text == "end of race")
                {
                    break;
                }
                else
                {
                    Regex regex = new Regex(@"[A-Za-z]");

                    MatchCollection matches = regex.Matches(text);

                    foreach (Match match in matches)
                    {
                        name += match.Value;
                    }

                    if (dict.ContainsKey(name))
                    {
                        MatchCollection matchesForDistance = Regex.Matches(text, @"[0-9]");

                        foreach (Match item in matchesForDistance)
                        {
                            distance += double.Parse(item.Value);
                        }

                        dict[name] += distance;
                    }
                }
            }
            dict = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            int counter = 1;

            foreach (var kvp in dict)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
