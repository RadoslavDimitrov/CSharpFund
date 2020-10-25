using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.emoji
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string emojiPattern = @"([:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1";
            //string emojiPattern = @"([:|*]{2})(?<name>([A-Z][a-z]{2})[a-z]*)\1";
            string digidsPattern = @"\d";

            var emojies = Regex.Matches(text, emojiPattern);
            var digids = Regex.Matches(text, digidsPattern).Select(x => int.Parse(x.Value)).ToList();

            List<string> coolEmojies = new List<string>();

            decimal coolnes = 0;

            if(digids.Count > 0)
            {
                coolnes = 1;

                for (int i = 0; i < digids.Count; i++)
                {
                    coolnes *= digids[i];
                }
            }
     

            decimal currCoolnes = 0;

            for (int i = 0; i < emojies.Count; i++)
            {
                string currEmoji = emojies[i].Groups["name"].Value.ToString();

                currCoolnes = 0;

                for (int k = 0; k < currEmoji.Length; k++)
                {
                    currCoolnes += currEmoji[k];
                }

                if(currCoolnes >= coolnes)
                {
                    coolEmojies.Add(emojies[i].ToString());
                    
                }
            }


            Console.WriteLine($"Cool threshold: {coolnes}");
            

            if (emojies.Count > 0)
            {
                Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");

                if(coolEmojies.Count > 0)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, coolEmojies));
                }
                
            }


        }
    }
}
