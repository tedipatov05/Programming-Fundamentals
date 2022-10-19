using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();
            bool change = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "Add":
                        int number = int.Parse(tokens[1]);
                        numbers.Add(number); change = true; break;
                    case "Remove":
                        int number1 = int.Parse(tokens[1]);
                        numbers.Remove(number1); change = true; break;
                    case "RemoveAt":
                        int number2 = int.Parse(tokens[1]);
                        numbers.RemoveAt(number2); change = true; break;
                    case "Insert":
                        int number3 = int.Parse(tokens[1]);
                        int number4 = int.Parse(tokens[2]);
                        numbers.Insert(number4, number3); change = true; break;
                    case "Contains":
                        int numberC = int.Parse(tokens[1]);
                        if (numbers.Contains(numberC))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> even = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                even.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", even));
                        break;
                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                odd.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string sign = tokens[1]; int numberF = int.Parse(tokens[2]);
                        if (sign == ">")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > numberF)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == "<")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < numberF)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == "<=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= numberF)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        else if (sign == ">=")
                        {
                            List<int> nov = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= numberF)
                                {
                                    nov.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", nov));
                        }
                        break;

                }
            }
            if (change == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        
    }
}