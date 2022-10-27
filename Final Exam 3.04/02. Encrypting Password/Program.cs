using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(\w+|\W+)>(?<decimal>\d{3})\|(?<wordSmall>[a-z]{3})\|(?<wordBig>[A-Z]{3})\|(?<symbols>[^<>]{3})<(\1)";

            Regex regex = new Regex(pattern);
            
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                bool isMatch = regex.IsMatch(input);
                if(isMatch)
                {
                   string password = match.Groups["decimal"].Value + match.Groups["wordSmall"].Value + match.Groups["wordBig"].Value + match.Groups["symbols"].Value;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
