using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int leftFoldIndex = intArr.Length / 4 - 1;
            int rightFoldIndex = 3 * intArr.Length / 4;

            int[] topArr = new int[intArr.Length / 2];

            int howManyNumbersSoFar = 0;
            for (int i = leftFoldIndex; i >= 0; i--)
            {
                howManyNumbersSoFar++;
                topArr[leftFoldIndex - i] = intArr[i];
            }
            for (int i = intArr.Length - 1; i >= rightFoldIndex; i--)
            {
                topArr[intArr.Length - 1 - i + howManyNumbersSoFar] = intArr[i];
            }


            int[] bottomArr = new int[intArr.Length / 2];

            for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
            {
                bottomArr[i - howManyNumbersSoFar] = intArr[i];
            }


            for (int i = 0; i < topArr.Length; i++)
            {
                Console.Write(topArr[i] + bottomArr[i] + " ");
            }

        }
    }
}
