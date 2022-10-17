using System;

namespace _3._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[] { 1, 1 };
            int sum = 0;

            switch (num)
            {
                case 1:
                    Console.WriteLine("1");
                    return;
                case 2:
                    Console.WriteLine("1");
                    return;
            }

            for (int i = 2; i < num; i++)
            {
                sum = array[0] + array[1];
                int[] newArray = new int[] { array[1], sum };

                array = newArray;
            }
            Console.WriteLine(sum);
        }
    }
}
