using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Aorder_by_Age
{
    class Person
    { 
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }   
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> listOfPersons = new List<Person>();
            while(input != "End")
            {
                string[] parts = input.Split(' '); 
                Person person = new Person(parts[0], parts[1], int.Parse(parts[2]));
                for(int i = 0; i < listOfPersons.Count; i++)
                {
                    if ( listOfPersons[i].Id == parts[1])
                    {

                        listOfPersons[i].Name = parts[0];
                        listOfPersons[i].Id = parts[1];
                        listOfPersons[i].Age = int.Parse(parts[2]);
                    }
                    
                }
                listOfPersons.Add(person);
                input = Console.ReadLine();
                    
            }
            listOfPersons=listOfPersons.OrderBy(x => x.Age).ToList();
            foreach(Person person in listOfPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
