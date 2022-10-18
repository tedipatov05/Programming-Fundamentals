using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input!="END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string num)
        {
            string reversed = string.Empty;
            for(int i=num.Length-1;i>=0;i--)
            {
                reversed += num[i];
            }
            if(reversed.Equals(num))
            {
                return true;

            }
            return false;
        }
    }
}
