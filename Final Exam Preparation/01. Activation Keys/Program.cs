using System;
using System.Text;
using System.Collections.Generic;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            string result = input;
            while (command != "Generate")
            {
                string[] cmd = command.Split(">>>");
                var cmd1 = cmd[0];
                var cmd2 = cmd[1];

                if (cmd1 == "Contains" && result.Contains(cmd2))
                {
                    Console.WriteLine($"{result} contains {cmd2}");
                }
                else if (cmd1 == "Contains" && !(result.Contains(cmd2)))
                {
                    Console.WriteLine("Substring not found!");
                }

                if (cmd1 == "Flip" && cmd2 == "Upper")
                {
                    int cmd3 = int.Parse(cmd[2]);
                    int cmd4 = int.Parse(cmd[3]);
                    string editedString = result.Substring(0, cmd3) + result.Substring(cmd3, cmd4 - cmd3).ToUpper() + result.Substring(cmd4);
                    Console.WriteLine(editedString);
                    result = editedString;
                }
                else if (cmd1 == "Flip" && cmd2 == "Lower")
                {
                    int cmd3 = int.Parse(cmd[2]);
                    int cmd4 = int.Parse(cmd[3]);
                    string editedString = result.Substring(0, cmd3) + result.Substring(cmd3, cmd4 - cmd3).ToLower() + result.Substring(cmd4);
                    Console.WriteLine(editedString);
                    result = editedString;
                }

                if (cmd1 == "Slice")
                {
                    int cmd3 = int.Parse(cmd[2]);
                    string editedString = result.Remove(int.Parse(cmd2), cmd3 - int.Parse(cmd2));
                    Console.WriteLine(editedString);
                    result = editedString;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {result}");
        }
        
    }
}
