using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = VowelsCount(input);
            Console.WriteLine(vowelsCount);
        }
        static int VowelsCount(string input)
        {
            string vowels = "UuIiOoAaEe";
            int count = 0;
            for(int i=0;i<input.Length;i++)
            {
                if(vowels.Contains(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
