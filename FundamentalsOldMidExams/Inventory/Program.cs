using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;
            List<string> currCommand = new List<string>();

            while ((command = Console.ReadLine()) != "Craft!")
            {
                currCommand = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if(currCommand[0] == "Collect")
                {
                    AddItem(items, currCommand);
                }
                else if(currCommand[0] == "Drop")
                {
                    DropItem(items, currCommand);
                }
                else if(currCommand[0] == "Combine Items")
                {
                    CombineItems(items, currCommand);
                }
                else if(currCommand[0] == "Renew")
                {
                    RenewItem(items, currCommand);
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }

        private static void CombineItems(List<string> items, List<string> currCommand)
        {
            List<string> itemForCombine = currCommand[1].Split(":", StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            for (int i = 0; i < items.Count; i++)
            {
                if (itemForCombine[0] == items[i])
                {
                    items.Insert(i + 1, itemForCombine[1]);
                }
            }
        }

        private static void RenewItem(List<string> items, List<string> currCommand)
        {
            string tempItem = string.Empty;

            for (int i = 0; i < items.Count; i++)
            {
                if (currCommand[1] == items[i])
                {
                    tempItem = items[i];
                    items.RemoveAt(i);
                    items.Add(tempItem);
                }
            }
        }

        private static void DropItem(List<string> items, List<string> currCommand)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (currCommand[1] == items[i])
                {
                    items.RemoveAt(i);
                }
            }
        }

        private static void AddItem(List<string> items, List<string> currCommand)
        {
            bool isHere = false;
            for (int i = 0; i < items.Count; i++)
            {
                if (currCommand[1] == items[i])
                {
                    isHere = true;
                }
                
            }

            if(isHere == false)
            {
                items.Add(currCommand[1]);
            }
        }
    }
}
