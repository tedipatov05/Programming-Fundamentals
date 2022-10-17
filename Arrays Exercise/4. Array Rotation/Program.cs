using System;
using System.Linq;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int swaps = int.Parse(Console.ReadLine());
            for(int i=0;i<swaps;i++)
            {
                int temp = input[0];
                for(int k=0;k<input.Length-1;k++)
                {
                    input[k] = input[k + 1];
                }
                input[input.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
