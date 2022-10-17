using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]%2==0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
