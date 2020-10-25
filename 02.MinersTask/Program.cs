using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02.MinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            Dictionary<string, int> inventory = new Dictionary<string, int>();
            ReadSortDictonari(inventory);
            PrintDictionari(inventory);
        }

        private static void ReadSortDictonari(Dictionary<string, int> inventory)
        {
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (inventory.ContainsKey(resource))
                {
                    inventory[resource] += quantity;
                }
                else
                {
                    inventory.Add(resource, quantity);
                }
            }
        }

        private static void PrintDictionari(Dictionary<string, int> inventory)
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
