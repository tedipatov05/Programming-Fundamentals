using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PriceProduct(name, quantity);
            
        }
        static void PriceProduct(string name, int quantity)
        {
            if(name=="coffee")
            {
                Console.WriteLine($"{quantity*1.5:f2}");
            }
            else if(name=="water")
            {
                Console.WriteLine($"{quantity*1:f2}");
            }
            else if(name=="coke")
            {
                Console.WriteLine($"{quantity*1.4:f2}");

            }
            else if(name=="snacks")
            {
                Console.WriteLine($"{quantity*2.00:f2}");
            }
        }
    }
}
