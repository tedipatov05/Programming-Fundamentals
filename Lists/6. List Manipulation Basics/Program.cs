using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] newcom = command.Split(" ");
                if(newcom[0] =="Add")
                {
                    numbers.Add(int.Parse(newcom[1]));
                }
                else if(newcom[0]=="Remove")
                {
                    numbers.Remove(int.Parse(newcom[1]));

                }
                else if(newcom[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(newcom[1]));
                }
                else if(newcom[0] == "Insert")
                {
                    numbers.Insert(int.Parse(newcom[2]), int.Parse(newcom[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
