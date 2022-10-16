using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberSonwballs = int.Parse(Console.ReadLine());
            BigInteger max = BigInteger.Zero;
            int hightestS = 0;
            int hightestT = 0;
            int hightestQ = 0;
            
            for (int i = 0; i < numberSonwballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger sum = (snowballSnow / snowballTime);
                BigInteger snowballValue = BigInteger.Pow(sum, snowballQuality);
                if (max<snowballValue)
                {
                    max = snowballValue;
                    hightestS = snowballSnow;
                    hightestQ = snowballQuality;
                    hightestT = snowballTime;
                }
            }
            Console.WriteLine($"{hightestS} : {hightestT} = {max} ({hightestQ})");
        }
    }
}
