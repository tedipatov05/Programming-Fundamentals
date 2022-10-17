using System;
using System.Linq;

namespace _10._Lady_Bugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short sizeOfField = short.Parse(Console.ReadLine());    // Field size input

            int[] initIndexes = Console.ReadLine()  // Array of the ladybug indexes of the next array
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] ladybugArray = new int[sizeOfField];  // Creating the lady bug array

            for (int i = 0; i < initIndexes.Length; i++)    // Filling the ladybug array with 1s on their indexes
            {


                if (initIndexes[i] >= 0 &&
                    initIndexes[i] < sizeOfField)
                {
                    ladybugArray[initIndexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split();

                int whichBug = int.Parse(commandArray[0]);

                if (whichBug >= 0 && whichBug < sizeOfField)
                {
                    int jumpPlaces = int.Parse(commandArray[2]);

                    if (ladybugArray[whichBug] == 1)
                    {
                        if (commandArray[1] == "left")
                        {
                            int jumpCount = 1;

                            int currLanding = whichBug - jumpPlaces * jumpCount;

                            while (currLanding >= 0 && ladybugArray[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break; // Breaking the loop if we jump 0 spaces to avoid perma-loop

                                jumpCount++;    // Increasing our jump multiplier if landing index is occupied

                                currLanding = whichBug - jumpPlaces * jumpCount;
                            }
                            if (currLanding >= 0)
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }
                        else if (commandArray[1] == "right")
                        {
                            int jumpCount = 1;
                            int currLanding = whichBug + jumpPlaces * jumpCount;

                            while (currLanding < sizeOfField && ladybugArray[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break;

                                jumpCount++;
                                currLanding = whichBug + jumpPlaces * jumpCount;
                            }

                            if (currLanding < sizeOfField)
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }
                    }
                }


                command = Console.ReadLine();

            }


            Console.WriteLine(string.Join(" ", ladybugArray));
        }
    }
}
