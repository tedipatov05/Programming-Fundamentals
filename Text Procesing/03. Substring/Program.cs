using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string removing = Console.ReadLine();
            while(removing.Contains(remove))
            {
                int ind = removing.IndexOf(remove);
                removing=removing.Remove(ind, remove.Length);
            }
            Console.WriteLine(removing);
        }
    }
}
