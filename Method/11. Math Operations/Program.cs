using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(num1,@operator,num2));
        }
        static double Calculate(int a, string @operator,int b)
        {
            double result = 0;
            switch(@operator)
            {
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = (a > b) ? a-b: b-a;
                    break;
                case "/":
                    result = a / b;
                    break;

            }
            return result;
        }
    }
}
