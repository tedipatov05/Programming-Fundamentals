using System;
using System.Linq;
using System.Collections.Generic;


namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            while(input != "End")
            {
                string[] vs = input.Split(" -> ");
                if(!company.ContainsKey(vs[0]))
                {
                    company.Add(vs[0], new List<string> { vs[1]});

                }
                else 
                {
                    if (!company[vs[0]].Contains(vs[1]))
                    {
                        company[vs[0]].Add(vs[1]);
                    }
                        
                }
                input = Console.ReadLine();
            }
            foreach(KeyValuePair<string, List<string>> pair in company)
            {
                Console.WriteLine(pair.Key);
                foreach(string v in pair.Value)
                {
                    Console.WriteLine($"-- {v}");
                }
            }
        }
    }
}
