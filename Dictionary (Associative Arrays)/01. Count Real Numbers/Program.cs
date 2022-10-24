using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            SortedDictionary<int, int> count = new SortedDictionary<int, int>();
            foreach(int num in nums)
            {
                if(count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count.Add(num, 1);
                }
            }
            foreach(var c in count)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
