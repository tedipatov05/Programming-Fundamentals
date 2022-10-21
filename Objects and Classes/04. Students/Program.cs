using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Student
    { 
        public Student(string firstname, string lastname, int age, string hometown)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            HomeTown = hometown;   


        }
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();   
            while(input != "end")
            {
                string[] tokens = input.Split(' ');
                string firstname = tokens[0];
                string lastname = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];
                Student student = new Student(firstname,lastname,age,hometown);
                students.Add(student);
                input = Console.ReadLine();
            }
            string filteredCity = Console.ReadLine();
            foreach(Student student in students)
            {
                if(student.HomeTown == filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
