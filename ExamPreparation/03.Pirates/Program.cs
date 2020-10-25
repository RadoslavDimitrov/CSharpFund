using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cityDict = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                CheckAndAddCity(cityDict, command);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "End")
            {
                string[] currCommand = secondCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string attackType = currCommand[0];
                string currTown = currCommand[1];

                if (attackType == "Plunder")
                {
                    PlunderCity(cityDict, currCommand, currTown);
                }
                else //Prosper
                {
                    int currGold = int.Parse(currCommand[2]);

                    if(currGold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        secondCommand = Console.ReadLine();
                        continue;
                    }

                    cityDict[currTown][1] += currGold;

                    Console.WriteLine($"{currGold} gold added to the city treasury. {currTown} now has {cityDict[currTown][1]} gold.");
                }

                secondCommand = Console.ReadLine();
            }

            if(cityDict.Count > 0)
            {
                Dictionary<string, List<int>> newDict = new Dictionary<string, List<int>>();

                newDict = cityDict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are { cityDict.Count} wealthy settlements to go to:");
                foreach (var item in newDict)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            
            
        }

        private static void PlunderCity(Dictionary<string, List<int>> cityDict, string[] currCommand, string currTown)
        {
            int currPpl = int.Parse(currCommand[2]);
            int currGold = int.Parse(currCommand[3]);

            Console.WriteLine($"{ currTown} plundered! {currGold} gold stolen, {currPpl} citizens killed.");
            int pplLeft = cityDict[currTown][0] - currPpl;
            int goldLeft = cityDict[currTown][1] - currGold;

            cityDict[currTown][0] -= currPpl;
            cityDict[currTown][1] -= currGold;

            if (pplLeft <= 0 | goldLeft <= 0)
            {
                Console.WriteLine($"{currTown} has been wiped off the map!");
                cityDict.Remove(currTown);
            }
        }

        private static void CheckAndAddCity(Dictionary<string, List<int>> cityDict, string command)
        {
            string[] currCity = command.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string currCityName = currCity[0];
            int currPpl = int.Parse(currCity[1]);
            int currGold = int.Parse(currCity[2]);

            if (!cityDict.ContainsKey(currCityName))
            {
                cityDict.Add(currCityName, new List<int>());
                cityDict[currCityName].Add(currPpl);
                cityDict[currCityName].Add(currGold);
            }
            else
            {
                cityDict[currCityName][0] += currPpl;
                cityDict[currCityName][1] += currGold;
            }
        }
    }
}
