using System;

namespace _4._Printing_Trianagle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i < height; i++)
            {
                PrintLine(1, i);
            }
            for(int k=height;k>=1;k--)
            {
                PrintLine(1, k);
            }
        }
        static void PrintLine(int start, int end)
        {
            for(int i=start;i<=end;i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
