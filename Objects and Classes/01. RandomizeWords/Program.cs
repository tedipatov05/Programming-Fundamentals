using System;
using System.Linq;

namespace _01._RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Random random = new Random();
            for (int i = 0; i < words.Length; i++)

            {

                int index= random.Next(0,words.Length);
                string currentword = words[i];
                words[i] = words[index];    
                words[index] = currentword;
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
