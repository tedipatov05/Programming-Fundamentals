using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            string[] matchPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}
