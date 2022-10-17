using System;
using System.Linq;

namespace _7__Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool identical = true;
            for(int i=0;i<arr1.Length;i++)
            {
                sum += arr2[i];
                if(arr1[i]!=arr2[i])
                {
                    identical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                
            }
            if(identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
