using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char[] ch = CharacterInRange(ch1, ch2);
            Console.WriteLine(String.Join(" ",ch));

        }
        static char[] CharacterInRange(char ch1, char ch2)
        {
            
            int j = 0;
            int start = Math.Min(ch1, ch2);
            int end = Math.Max(ch1, ch2);
            char[] output = new char[end - start-1];
            for (int i=++start; i<end;i++)
            {
                
                output[j] = (char)i;
                j++;
                
            }
            return output;
        }
    }
}
