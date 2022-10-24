using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> output = new Dictionary<string, int>(); 
            while(input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(output.ContainsKey(input))
                {
                    output[input] += quantity;
                }
                else
                {
                    output.Add(input, quantity);
                }
                input = Console.ReadLine();
            }
            foreach(var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
