using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');


            int health = 100;
            int bitcoins = 0;

            int currHealth = 0;
            int tempHealth = 0;
            bool notDead = true;
            for (int i = 0; i < rooms.Length; i++)
            {
                int currBitcoins = 0;
                string command = rooms[i];
                string[] splitted = command.Split();
                if (splitted[0] == "potion")
                {
                    currHealth = health;
                    tempHealth = health;
                    currHealth += int.Parse(splitted[1]);
                    if (currHealth <= 100)
                    {
                        health += int.Parse(splitted[1]);
                        Console.WriteLine($"You healed for {splitted[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else if (currHealth > 100)
                    {
                        int diff = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                }
                else if (splitted[0] == "chest")
                {
                    bitcoins += int.Parse(splitted[1]);
                    currBitcoins += int.Parse(splitted[1]);
                    Console.WriteLine($"You found {currBitcoins} bitcoins.");

                }
                else
                {
                    int attack = int.Parse(splitted[1]);
                    health -= attack;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {splitted[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        notDead = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {splitted[0]}.");
                    }
                }
            }
            if (notDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
