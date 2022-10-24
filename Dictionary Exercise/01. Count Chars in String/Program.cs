using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            for(int i = 0; i < input.Length; i++)
            {
                char[] vs = input.ToCharArray();
                if(occurrences.ContainsKey(vs[i]))
                {
                    occurrences[vs[i]]++;
                }
                else if(vs[i] != ' ')
                {
                    occurrences.Add(vs[i], 1);
                }

            }
            foreach(var count in occurrences)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
