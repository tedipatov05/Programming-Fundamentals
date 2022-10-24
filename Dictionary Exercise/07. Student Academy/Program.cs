using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
           for(int i = 0; i < n; i++)
           {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(!grades.ContainsKey(name))
                {
                     grades.Add(name, new List<double> {grade });
                }
                else
                {
                    grades[name].Add(grade);    
                }
               
           }

            foreach(var grade in grades.Where(x => x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{grade.Key} -> {grade.Value.Average():f2}");
            }
        }
    }
}
