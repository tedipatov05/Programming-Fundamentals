namespace ConsoleApp14
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digitsCount = GetNumberOfDigits(input);
            var isOnly = IsOnlyLettersAndDigits(input);
            var isValidLength = input.Length >= 6 && input.Length <= 10;
            if (!isValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnly)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (digitsCount >= 2 && isOnly && isValidLength)
            {
                Console.WriteLine("Password is valid");
            }
        }
        public static int GetNumberOfDigits(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public static bool IsOnlyLettersAndDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}