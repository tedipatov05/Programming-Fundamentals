using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._From_Left_to_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                string[] value = input.Split(" ");

                long num1 = long.Parse(value[0]);
                long num2 = long.Parse(value[1]);

                long biggerNum = num2;
                if(num1>num2)
                {
                    biggerNum = num1;
                }

                long sumOfDigits = 0;
                while(biggerNum!=0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;


                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
            
        }
    }
}
