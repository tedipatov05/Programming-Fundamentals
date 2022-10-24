using System;
using System.Linq;
using System.Collections.Generic;


namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, string> park = new Dictionary<string, string>();   
            for(int i = 0; i < n; i++)
            {
                string commands = Console.ReadLine();
                string[] vs = commands.Split(' ');
                if(vs[0]=="register")
                {
                    if(park.ContainsKey(vs[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {vs[2]}");
                    }
                    else
                    {
                        park.Add(vs[1], vs[2]);
                        Console.WriteLine($"{vs[1]} registered {vs[2]} successfully");
                    }
                }
                else if(vs[0]=="unregister")
                {
                    if(!park.ContainsKey(vs[1]))
                    {
                        Console.WriteLine($"ERROR: user {vs[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{vs[1]} unregistered successfully");
                        park.Remove(vs[1]);
                    }
                }
            }
            foreach(KeyValuePair<string, string> pair in park)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
