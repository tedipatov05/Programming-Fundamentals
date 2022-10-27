using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Pirates
{
    class City
    { 
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
        public string Name { get; set; }    
        public int Population { get; set; }
        public int Gold { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> map = new Dictionary<string, City>();
            while(input !="Sail")
            {
                string[] inputArgs = input.Split("||").ToArray();
                string cityName = inputArgs[0];
                int population = int.Parse(inputArgs[1]);
                int gold = int.Parse(inputArgs[2]);
                City city = new City(cityName, population, gold);
                if(!map.ContainsKey(cityName))
                {
                    map.Add(cityName, city);
                }
                else
                {
                    map[cityName].Population += population;
                    map[cityName].Gold += gold;
                }
                input = Console.ReadLine();
                
            }
            string command = Console.ReadLine();
            while(command != "End" )
            {
                string[] cmdArgs = command.Split("=>").ToArray();
                string cmdType = cmdArgs[0];
                if(cmdType =="Plunder")
                {
                    string townName = cmdArgs[1];
                    int peopleKilled = int.Parse(cmdArgs[2]);
                    int goldStolen = int.Parse(cmdArgs[3]);
                    map[townName].Population -= peopleKilled;
                    map[townName].Gold -= goldStolen;
                    Console.WriteLine($"{townName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                    if (map[townName].Population == 0 || map[townName].Gold == 0)
                    {
                        Console.WriteLine($"{townName} has been wiped off the map!");
                        map.Remove(townName);
                    }


                }
                else if(cmdType =="Prosper")
                {
                    string townName = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);
                    if(gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        
                    }
                    else
                    {
                        
                        map[townName].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {map[townName].Gold} gold.");
                    }
                }
                command = Console.ReadLine();
            }
            
            if(map.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {map.Count} wealthy settlements to go to:");
                foreach (var item in map)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                
            }
           
        }
    }
}
