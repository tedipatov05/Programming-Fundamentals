using System;
using System.Linq;
using System.Collections.Generic;


namespace _04._Students
{
    class Students
    {
        public Students(string firstname, string lastname, double grade)
        {
            FirstName = firstname;
            LastName = lastname;    
            Grade = grade;

        }
        public string FirstName { get; set; }   
        public string LastName { get; set; }    
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>(); 
            for(int i = 0; i < n; i++)
            {
               string[] input = Console.ReadLine().Split(' ').ToArray();
                Students student = new Students(input[0],input[1],double.Parse(input[2]));
                students.Add(student);
            }
            students = students.OrderBy(x => x.Grade).Reverse().ToList(); 
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
    }
}
