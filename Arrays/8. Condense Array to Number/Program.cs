using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            int length = nums.Length-1;
            for (int i=0;i<length;i++)
            {
                int[] condensed = new int[nums.Length];
                for(int j=0;j<nums.Length-1;j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
                
            }
            Console.WriteLine(nums[0]);
            
        }
    }
}
