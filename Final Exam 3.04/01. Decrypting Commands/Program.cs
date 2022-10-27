using System;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while(command != "Finish")
            {
                string[] cmdArgs = command.Split(' ');
                string cmdType = cmdArgs[0];
                if(cmdType =="Replace")
                {
                    string currchar = cmdArgs[1];
                    string newchar =cmdArgs[2];
                    message = message.Replace(currchar, newchar);
                    Console.WriteLine(message);
                }
                else if(cmdType =="Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int count = (endIndex - startIndex) + 1;
                    if (ValidIndex(startIndex, endIndex, message))
                    {
                        message = message.Remove(startIndex, count);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");

                    }
                    
                }
                else if (cmdType =="Make")
                {
                    string cmd = cmdArgs[1];
                    if(cmd == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if(cmd =="Lower")
                    {
                        message = message.ToLower();   

                    }
                    Console.WriteLine(message);
                }
                else if(cmdType =="Check")
                {
                    string substring = cmdArgs[1];
                    if(message.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }

                }
                else if(cmdType == "Sum")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse (cmdArgs[2]);
                    if(ValidIndex(startIndex,endIndex,message))
                    {
                        Console.WriteLine(Sum(startIndex,endIndex,message));
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                        
                    }
                    
                }
                command = Console.ReadLine();
            }
          


        }
        static int Sum(int startIndex, int endIndex, string message)
        {
            int sum = 0;
            for(int i = startIndex; i <= endIndex; i++)
            {
                sum+=message[i];
            }
            return sum;
        }
        static bool ValidIndex(int startIndex, int endIndex,string message)
        {
            if(!(startIndex >=0 && endIndex<message.Length))
            {
                return false;
            }
            return true;
        }
    }
}
