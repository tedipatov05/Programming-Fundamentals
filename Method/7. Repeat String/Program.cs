using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string result = RepeatString(template, num);
            Console.WriteLine(result);
        }
        static string RepeatString(string template, int numberOfRepeates)
        {
            string result = string.Empty;
            for (int i = 0; i < numberOfRepeates; i++)
            {
                result += template;
            }
            return result;
        }
    }
}
