using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for(int i=0;i<input.Length;i++)
            {
                bool isBigger = true;
                for(int k=i+1;k<input.Length;k++)
                {
                    if(input[i]<=input[k])
                    {
                        isBigger = false;

                    }
                }
                if(isBigger)
                {
                    Console.Write(input[i]+ " ");
                }
            }
            
        }
    }
}
