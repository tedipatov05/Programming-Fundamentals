using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            while (input != "buy")
            {
                string[] vs = input.Split(' ');
                string product = vs[0];
                List<double> list = new List<double>();
                list.Add(double.Parse(vs[1]));
                list.Add(double.Parse(vs[2]));
                if (orders.ContainsKey(product))
                {
                    orders[product][1] += double.Parse(vs[2]);
                    orders[product][0] = double.Parse(vs[1]);
                }
                else
                {
                    orders.Add(product, list);
                }
                input = Console.ReadLine();

            }
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {(order.Value[0] * order.Value[1]):f2}");
            }
        }
    }
}
