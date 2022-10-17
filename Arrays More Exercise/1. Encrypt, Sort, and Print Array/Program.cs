using System;

namespace _1._Encrypt__Sort__and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOfSum = new int[n];
            string vowels = "AaUuIiOoEe";
            
            for(int i=0;i<n;i++)
            {
                string name = Console.ReadLine();
                int sumVowels = 0;
                int sumConsonant = 0;
                int sum = 0;
                for (int j=0;j<name.Length;j++)
                {
                    char currLetter = name[j];
                    if(vowels.Contains(currLetter))
                    {
                        sumVowels += currLetter * name.Length;
                        
                    }
                    else
                    {
                        sumConsonant += currLetter / name.Length;
                    }
                    
                }
                sum = sumConsonant + sumVowels;
                arrOfSum[i] = sum;

                
            }
            Array.Sort(arrOfSum);
            for(int i=0;i<arrOfSum.Length;i++)
            {
                Console.WriteLine(arrOfSum[i]);
            }

        }
    }
}
