using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(GetTopInt(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool GetTopInt(int n)
        {
            int sumOfDigits = 0;
            bool isOdd = false;
            int lastDigit;
            while(n>0)
            {
                sumOfDigits += n % 10;
                lastDigit = n % 10;
                if(lastDigit%2!=0)
                {
                    isOdd = true;
                }
                n /= 10;
                

            }
            if(isOdd==true && sumOfDigits%8==0)
            {
                return true;
            }
            return false;
        }
    }
}
