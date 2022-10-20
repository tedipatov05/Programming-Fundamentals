using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();
            int moveCount = 0;
            while (command != "end")
            {
                moveCount++;
                int[] gueses = command.Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (isInvalidGuess(gueses[0], gueses[1], elements))
                {
                    int middleOfElements = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElements, elementToAdd);
                    elements.Insert(middleOfElements, elementToAdd);

                }
                else if (elements[gueses[0]] == elements[gueses[1]])
                {
                    string guessedElements = elements[gueses[0]];
                    elements.Remove(guessedElements);
                    elements.Remove(guessedElements);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElements}!");

                }
                else if (elements[gueses[0]] != elements[gueses[1]])
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                }
               

                command = Console.ReadLine();
            }
            if (elements.Count>0)
            {
                Console.WriteLine("Sorry you lose :()");
                Console.WriteLine(String.Join(" ",elements));
            }
        }
        static bool isInvalidGuess(int firstguess, int secondguess, List<string> elements)
        {
            return firstguess == secondguess || !isInList(firstguess, elements) || !isInList(secondguess, elements);
            static bool isInList(int guess, List<string> elements)
            {
                return guess >= 0 && guess < elements.Count;
            }
        }
    }
}
