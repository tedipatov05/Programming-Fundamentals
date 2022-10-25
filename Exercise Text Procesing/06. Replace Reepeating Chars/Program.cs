using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Replace_Reepeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> str = Console.ReadLine().ToList();

            for (int i = 0; i < str.Count - 1; i++)
            {
                char curr = str[i];
                char next = str[i + 1];
                if (curr == next)
                {
                    str.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", str));


        }
    }
}
