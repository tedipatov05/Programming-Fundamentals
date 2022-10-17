using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int k=i+1;k<=arr.Length-1;k++)
                {
                    if(arr[i]+arr[k]==magicNum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[k]}");
                    }
                }
            }
        }
    }
}
