using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chat = Console.ReadLine();
            List<string> output = new List<string>();
            while(chat != "end")
            {
                string[] messages = chat.Split(' ');
                string action = messages[0];
                if(action =="Chat")
                {
                    output.Add(messages[1]);                
                }
                else if(action =="Delete")
                {
                    if(output.Contains(messages[1]))
                    {
                        output.Remove(messages[1]);
                    }
                    else
                    {
                        chat=Console.ReadLine();
                        continue;
                    }
                }
                else if(action=="Edit")
                {
                    if (output.Contains(messages[1]))
                    {
                        int index = output.IndexOf(messages[1]);
                        output[index] = messages[2];
                    }
                    else
                    {
                        chat = Console.ReadLine();
                        continue;
                    }

                }
                else if(action=="Pin")
                {
                    if(output.Contains(messages[1]))
                    {
                        string mess = messages[1];
                        output.Remove(messages[1]);
                        output.Add(mess);
                    }
                    else
                    {
                        chat= Console.ReadLine();
                        continue;
                    }
                    
                }
                else if(action=="Spam")
                {
                    for (int i = 1; i < messages.Length; i++)
                    {
                        output.Add(messages[i]);
                    }
                }
                chat = Console.ReadLine();
            }
            for (int i = 0; i < output.Count(); i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
