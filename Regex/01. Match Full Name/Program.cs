using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfNames = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(listOfNames);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }

            Console.WriteLine();

        }
    }
}
