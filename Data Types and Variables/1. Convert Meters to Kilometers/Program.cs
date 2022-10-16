using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceMetres  = int.Parse(Console.ReadLine());
            double distanceKm = distanceMetres / 1000.0;
            Console.WriteLine($"{Math.Round(distanceKm,2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}
