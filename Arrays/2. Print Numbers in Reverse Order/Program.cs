using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums[i]=number;
            }
            for(int j=nums.Length-1;j>=0;j--)
            {
                Console.Write(nums[j] + " ");

            }
        }
    }
}
