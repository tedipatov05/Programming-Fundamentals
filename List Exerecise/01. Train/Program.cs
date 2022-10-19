using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while(input!="end")
            {
                string[] command = input.Split(' ');

                if(command[0]=="Add")
                {
                    int number = int.Parse(command[1]);
                    wagons.Add(number);
                }
                else
                {
                    int number = int.Parse(command[0]);
                    wagons = FitPassengersInWagon(wagons, number, wagonCapacity);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',wagons));

        }
        static List<int> FitPassengersInWagon(List<int> wagon, int passengers, int capacity)
        {
            for (int i = 0; i < wagon.Count; i++)
            {
                if(wagon[i]+passengers<=capacity)
                {
                    wagon[i] += passengers;
                    break;
                }

            }
            return wagon;
        }
    }
}
