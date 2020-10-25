using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> playersInDict = new Dictionary<string, int>();

            string command = Console.ReadLine();

            //string pattern = @"(?<name>[A-Za-z])|(?<distance>\d)";
            string namePattern = @"(?<name>[A-Za-z\s]+)";
            string digitsPattern = @"\d";

            while (command != "end of race")
            {
                MatchCollection collection = Regex.Matches(command, namePattern, RegexOptions.IgnoreCase);

                string name = string.Empty;

                for (int i = 0; i < collection.Count; i++)
                {
                    name = name + collection[i];
                }


                MatchCollection collectionInNumbers = Regex.Matches(command, digitsPattern, RegexOptions.IgnoreCase);

                int distance = 0;

                for (int i = 0; i < collectionInNumbers.Count; i++)
                {
                    distance += int.Parse(collectionInNumbers[i].ToString());
                }


                if (players.Contains(name))
                {
                    if (!playersInDict.ContainsKey(name))
                    {
                        playersInDict.Add(name, distance);
                    }
                    else
                    {
                        playersInDict[name] += distance;
                    }
                }




                command = Console.ReadLine();
            }

            playersInDict = playersInDict.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"1st place: {playersInDict.Keys.First()}");
            Console.WriteLine($"2nd place: {playersInDict.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {playersInDict.Keys.ElementAt(2)}");


        }
    }
}
