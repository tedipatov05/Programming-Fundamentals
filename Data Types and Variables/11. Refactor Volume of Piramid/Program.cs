﻿using System;

namespace _11._Refactor_Volume_of_Piramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double V = (length*width*height)/ 3;
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
