using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> input = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length%2==0)
                .ToList();
            foreach (string inputItem in input)
            {
                Console.WriteLine(inputItem);
            }
        }
    }
}
