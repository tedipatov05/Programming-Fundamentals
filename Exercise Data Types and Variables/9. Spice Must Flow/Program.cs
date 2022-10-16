using System;

namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int days = 0;
            int leaved = 0;
            while(startYield>=100)
            {     
                leaved += startYield - 26;
                days++;
                startYield -= 10;
                
            }
            if(leaved>=26)
            {
                leaved -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(leaved);
        }
    }
}
