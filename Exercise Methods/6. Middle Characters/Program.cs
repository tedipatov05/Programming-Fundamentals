using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleChar(input));
        }
        static string GetMiddleChar(string str)
        {
            int length = str.Length;
            string result = string.Empty;
            if(length%2==0)
            {
                result = str[length / 2 - 1] + str[length / 2].ToString();
            }
            else
            {
                result = str[length / 2].ToString();
            }
            return result;
        }
    }
}
