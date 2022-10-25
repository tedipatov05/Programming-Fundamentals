using System;
using System.Text;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder digits = new StringBuilder();
            //StringBuilder letters = new StringBuilder();
            //StringBuilder other = new StringBuilder();

            string text = Console.ReadLine();

            char[] allDigits = text
                .Where(item => char.IsDigit(item))
                .ToArray();
            char[] allLetters = text
                .Where(item => char.IsLetter(item))
                .ToArray();
            char[] other = text
                .Where(item => !char.IsLetter(item) && !char.IsDigit(item))
                .ToArray();

            Console.WriteLine(new string(allDigits));
            Console.WriteLine(new string(allLetters));
            Console.WriteLine(new string(other));

            
        }
    }
}
