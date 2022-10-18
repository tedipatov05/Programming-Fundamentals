using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateType = Console.ReadLine();
            switch (dateType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string resultString = GetMax(firstString, secondString);
                    Console.WriteLine(resultString);

                    break;
            }
        }
        static int GetMax(int a, int b)
        {
            if(a>b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            int comparison = a.CompareTo(b);
            if(comparison>0)
            {
                return a;
            }
            return b;
        }

    }
}
