using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundedNums = new int[input.Length];
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]==-0.00)
                {
                    roundedNums[i] = 0;
                }
                
                
                roundedNums[i] = (int)Math.Round(input[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {roundedNums[i]}");
            }
        }
    }
}
