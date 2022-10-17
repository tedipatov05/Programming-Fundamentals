using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;
                
            for(int i=0;i<arr.Length;i++)
            {
                int sumLeft = 0;
                for(int k=0;k<i;k++)
                {
                    sumLeft += arr[k];
                }

                int sumRight = 0;
                for (int j=arr.Length-1;j>i;j--)
                {
                    sumRight += arr[j];
                }
                if(sumLeft==sumRight)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }
            if(!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
