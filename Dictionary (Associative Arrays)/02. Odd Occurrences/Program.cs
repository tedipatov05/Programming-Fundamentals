using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> output = new Dictionary<string, int>();
            foreach(var c in input)
            {
                string lowerWord = c.ToLower();
                if(output.ContainsKey(lowerWord))
                {
                    output[lowerWord]++;
                }
                else
                {
                    output.Add(lowerWord, 1);
                }
            }
            foreach(var item in output)
            {
                if(item.Value%2!=0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
