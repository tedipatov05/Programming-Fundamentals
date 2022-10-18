using System;

namespace _2._Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintGrades(double.Parse(Console.ReadLine()));
        }
        static void PrintGrades(double grade)
        {
            if(grade>=2.00 && grade<3.00)
            {
                Console.WriteLine("Fail");
            }
            else if(grade>=3.00 && grade<3.5 )
            {
                Console.WriteLine("Poor");
            }
            else if(grade>=3.5 && grade<4.5)
            {
                Console.WriteLine("Good");
            }
            else if(grade>=4.5 && grade<5.5)
            {
                Console.WriteLine("Very good");
            }
            else if(grade>=5.5 && grade<=6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {

            }
        }
    }
}
