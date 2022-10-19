using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int longerCount = Math.Max(list2.Count, list1.Count);
            for (int i = 0; i < longerCount; i++)
            {
                if (i <list1.Count)
                {
                    result.Add(list1[i]);
                }
                if (i < list2.Count)
                {
                    result.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
