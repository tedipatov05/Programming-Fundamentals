using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split();

            string[] second = Console.ReadLine()
                .Split();

            string result = "";

            foreach (var element in second)
            {
                if (first.Contains(element))
                {
                    result += " " + element;
                    //Console.Write($" {kvp}");
                }
            }

            Console.Write($"{result.Trim()}");
        }
    }
}
