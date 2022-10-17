using System;


namespace _2._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[][] pascalTriangle = new int[lines][];

            for (var row = 0; row < lines; row++)
            {
                pascalTriangle[row] = new int[row + 1];
                pascalTriangle[row][0] = 1;  
                pascalTriangle[row][^1] = 1; 

                for (var col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            for (var row = 0; row < lines; row++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }
        }
    }
}
