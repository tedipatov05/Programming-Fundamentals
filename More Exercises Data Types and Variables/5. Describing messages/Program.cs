using System;

namespace _5._Describing_messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string descrypt = "";
            int addKey = 0;
            for(int i=0;i<n;i++)
            {
                char letter = char.Parse(Console.ReadLine());
                addKey = letter + key;
                char character = (char)addKey;
                descrypt += character;
                addKey = 0;
            }
            Console.WriteLine(descrypt);
        }
    }
}
