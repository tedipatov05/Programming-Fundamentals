using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex validator = new Regex(@"([:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1");
            Regex coolThresholdValidator = new Regex(@"\d");
            List<string> coolEmojis = new List<string>();
            int coolThreshold = 0;
            int sumEmoji = 0;
            int emojisInText = 0;
            string input = Console.ReadLine();
            if (validator.IsMatch(input) || coolThresholdValidator.IsMatch(input))
            {
                MatchCollection matchesThreshold = coolThresholdValidator.Matches(input);
                int[] matchesToArr = matchesThreshold.Select(v => int.Parse(v.Value)).ToArray();
                coolThreshold = matchesToArr.Aggregate((a, b) => a * b);
                MatchCollection emojis = validator.Matches(input);
                emojisInText += emojis.Count;
                foreach (Match emoji in emojis)
                {

                    string emojiToString = emoji.Groups["name"].Value;
                    for (int curr = 0; curr < emojiToString.Length; curr++)
                    {
                        if (char.IsLetter(emojiToString[curr]))
                        {
                            sumEmoji += emojiToString[curr];
                        }
                    }
                    if (sumEmoji > coolThreshold)
                    {
                        coolEmojis.Add(emoji.Value);
                    }
                    sumEmoji = 0;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojisInText} emojis found in the text. The cool ones are:");
            foreach (string emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }


        }
    }
}
