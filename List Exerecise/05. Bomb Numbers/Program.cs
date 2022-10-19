﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bombInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            //int indexOfBomb;
            //while ((indexOfBomb = numbers.IndexOf(bombNumber)) >= 0)
            //{

            //}

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);

                if (indexOfBomb == -1)
                {
                    //There are no more bombs inside the list
                    break;
                }

                DetonateBomb(numbers, indexOfBomb, bombPower);
            }

            Console.WriteLine(numbers.Sum());
        }

        
        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {
            //Delete elements at the bomb and right to it
            int rightCount = indexOfBomb + bombPower;
            for (int cnt = indexOfBomb; cnt <= rightCount; cnt++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(indexOfBomb);
            }

            //Delete elements left to the bomb
            int leftCount = indexOfBomb - bombPower;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int cnt = leftCount; cnt < indexOfBomb; cnt++)
            {
                //if (leftCount >= numbers.Count)
                //{
                //    //It is impossible
                //    break;
                //}

                numbers.RemoveAt(leftCount);
            }
        }
    }
}
