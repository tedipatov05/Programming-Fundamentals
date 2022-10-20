using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    789+internal class Program

    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = Console.ReadLine();
            while(input != "Craft!")
            {
                string[] command = input.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                if(action=="Collect")
                {
                    if(!items.Contains(command[1]))
                    {
                        items.Add(command[1]);  
                    }
                    else
                    {
                        input=Console.ReadLine();
                        continue;
                    }
                }
                else if(action=="Drop")
                {
                    if(items.Contains(command[1]))
                    {
                        items.Remove(command[1]);
                    }
                }
                else if(action=="Combine Items")
                {
                    string[] item = command[1].Split(':',StringSplitOptions.RemoveEmptyEntries);
                    if(items.Contains(item[0]))
                    {
                        int index = items.IndexOf(item[0]);
                        items.Insert(index+1, item[1]);
                    }
                    else
                    {
                       input = Console.ReadLine();
                        continue;
                    }
                    
                }
                else if(action=="Renew")
                {
                    if (items.Contains(command[1])) 
                    {
                        string putlast = command[1];
                        items.Remove(putlast);
                        items.Add(putlast);
                        
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ",items));

        }
    }
}
