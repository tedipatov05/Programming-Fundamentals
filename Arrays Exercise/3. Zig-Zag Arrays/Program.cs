using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int count1 = 0;
            
            for (int i = 1; i <= n; i++)
            {
                
                int[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if(i%2==0)
                {
                    arr1[count1] = input[0];
                    arr2[count1] = input[1];
                    count1++;
                }
                else
                {
                    arr1[count1] = input[1];
                    arr2[count1] = input[0];
                    count1++;
                }
                
                
            }
            Console.WriteLine(string.Join(' ',arr2));
            Console.WriteLine(string.Join(' ', arr1));
        }
    }
}
