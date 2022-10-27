using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            foreach( string s in input)
            {
                string[] split = s.Split(": ",StringSplitOptions.RemoveEmptyEntries);
                if(dictionary.ContainsKey(split[0]))
                {
                    dictionary[split[0]].Add(split[1]);
                }
                else
                {
                    dictionary.Add(split[0], new List<string> { split[1] });
                }
                
            }
            string[] test = Console.ReadLine().Split(" | ",StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();
            if(command == "Test")
            {
                foreach( string s in test)
                {
                    if(dictionary.ContainsKey(s))
                    {
                        Console.WriteLine($"{s}:");
                        foreach(var str in dictionary[s])
                        {
                            Console.WriteLine($" -{str}");
                        }
                        
                    }
                }
            }
            else if(command =="Hand Over")
            {
                List<string> vs = new List<string>();   
                foreach(var item in dictionary)
                {
                    vs.Add(item.Key);
                }
                Console.WriteLine(string.Join(" ",vs));
               
            }
            

        }
    }
}
