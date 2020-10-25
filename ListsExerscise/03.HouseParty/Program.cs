using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> ppl = new List<string>();


            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command.Count == 3)
                {
                    ppl = CheckIsHere(ppl, command);
      
                }
                else if (command.Count == 4)
                {
                    ppl = CheckLeaving(ppl, command);
                    
                }

            }

            foreach (var name in ppl)
            {
                Console.WriteLine(name);
            }
        }

        private static List<string> CheckLeaving(List<string> ppl, List<string> command)
        {
            bool isNotInList = false;
            for (int currName = 0; currName < ppl.Count; currName++)
            {
                if (command[0] == ppl[currName])
                {
                    ppl.Remove(command[0]);
                    isNotInList = true;
                    break;
                }

            }

            if (isNotInList == false)
            {
                Console.WriteLine($"{command[0]} is not in the list!");
            }

            return ppl;
        }

        private static List<string> CheckIsHere(List<string> ppl, List<string> command)
        {
            bool isInList = false;
            for (int j = 0; j < ppl.Count; j++)
            {
                if (command[0] == ppl[j])
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                    isInList = true;
                    break;

                }

            }

            if (isInList == false)
            {
                ppl.Add(command[0]);
            }

            return ppl;
        }
    }
}
