using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double pricesWithoutTax = 0;
            double totalPrice = 0;
            while(command != "special"  && command!="regular")
            {
                double price = double.Parse(command);
                if(price<0)
                {
                    Console.WriteLine("Invalid price!");
                    command=Console.ReadLine();
                    continue;
                }
                pricesWithoutTax += price;

                command = Console.ReadLine();
                  
            }
            if(pricesWithoutTax==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double taxes= pricesWithoutTax * 0.2;
            if (command=="special")
            {
                double totalWithTaxes = pricesWithoutTax + taxes;
                double totalPriceWithDiscount = totalWithTaxes * 0.9;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {pricesWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithDiscount:f2}$");
            }
            else if (command=="regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {pricesWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(pricesWithoutTax+taxes):f2}$");
            }

        }
    }
}
