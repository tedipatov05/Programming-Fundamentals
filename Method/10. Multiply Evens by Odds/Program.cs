using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            int evenDigitsSum = GetSumOfEvenDigits(num);
            int oddDigitsSum = GetSumOfOddDigits(num);
            Console.WriteLine(evenDigitsSum*oddDigitsSum);
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            
            while(num>0)
            {
                int digit = Math.Abs(num % 10);
                if(digit%2==0)
                {
                    sum += digit;
                    
                }
                num /= 10;
            }
            return sum;

        }
        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = Math.Abs(num % 10);
                if (digit % 2 != 0)
                {
                    sum += digit;
                    
                }num /=  10;

            }
            return sum;

        }
    }
}
