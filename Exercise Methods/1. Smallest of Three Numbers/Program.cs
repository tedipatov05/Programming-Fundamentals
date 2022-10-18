using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i=0;i<3;i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            int min = SmallestNum(arr);
            Console.WriteLine(min);
        }
        static int SmallestNum(int[] arr)
        {
            int min = arr.Min();
            return min;

        }
    }
}
