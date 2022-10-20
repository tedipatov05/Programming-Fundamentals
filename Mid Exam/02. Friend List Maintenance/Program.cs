using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = Console.ReadLine();
            while(input != "Report")
            {
                string[] command = input.Split();
                string action = command[0];
                if (action == "Blacklist")
                {
                    if(list.Contains(command[1]))
                    {
                        int index = list.IndexOf(command[1]);
                        Console.WriteLine($"{list[index]} was blacklisted.");
                        list[index] = "Blacklisted";

                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                    
                }
                else if(action=="Error")
                {
                    int index = int.Parse(command[1]);
                    if(IsValidIndex(list, index) && list[index]!= "Blacklisted" && list[index]!="Lost")
                    {
                        Console.WriteLine($"{list[index]} was lost due to an error.");
                        list[index] = "Lost";
                        

                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                }
                else if(action=="Change")
                {
                    
                    int index = int.Parse(command[1]);
                    if (IsValidIndex(list, index))
                    {
                        string name = command[2];
                        Console.WriteLine($"{list[index]} changed his username to {name}. ");
                        list[index] = name;
                    }
                    else
                    {
                        input= Console.ReadLine();
                        continue;
                    }
                    
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {list.Count(n=>n=="Blacklisted")} ");
            Console.WriteLine($"Lost names: {list.Count(n=>n=="Lost")}");
            Console.WriteLine(string.Join(" ",list));
        }
        static bool IsValidIndex(List<string> list,int index)
        {
            if(index>=0 && index<=list.Count-1)
            {
                return true;
            }
            return false;
        }
    }
}
