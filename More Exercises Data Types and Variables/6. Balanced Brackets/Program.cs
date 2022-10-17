using System;

namespace _6._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Linq;


namespace Test
    {
        class Program
        {

            public static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                int openCount = 0;
                int closeCount = 0;

                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    if (input == "(")
                    {
                        openCount++;

                    }
                    else if (input == ")")
                    {
                        closeCount++;
                        if (openCount - closeCount != 0)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                }
                if (openCount == closeCount)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}
    }
}
