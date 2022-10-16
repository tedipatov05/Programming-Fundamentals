using System;

namespace _9._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string result = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
            Console.WriteLine(result);


        }
    }
}
