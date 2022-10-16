using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double maxV = double.MinValue;
            string maxM = "";
            
            for(int i=0;i<n;i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double V = Math.PI * r * r * height;
                if(maxV<V)
                {
                    maxV = V;
                    maxM = model;
                }
            }
            Console.WriteLine(maxM);
        }
    }
}
