using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list =Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] tokens = command.Split(' ');
                if(tokens[0]=="Delete")
                {
                    list.Remove(int.Parse(tokens[1]));

                }
                else if(tokens[0] == "Insert")
                {
                    int num = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    list.Insert(index, num);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',list));
        }
    }
}
