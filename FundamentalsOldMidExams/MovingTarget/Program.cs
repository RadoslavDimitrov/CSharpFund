using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var currCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                int index = int.Parse(currCommand[1]);
                int valueRadius = int.Parse(currCommand[2]);

                if(currCommand[0] == "Shoot")
                {
                    Shoot(targets, index, valueRadius);

                }
                else if(currCommand[0] == "Add")
                {
                    Add(targets, index, valueRadius);
                }
                else if(currCommand[0] == "Strike")
                {
                    Strike(targets, index, valueRadius);
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static void Strike(List<int> targets, int index, int valueRadius)
        {
            if(index + valueRadius < targets.Count && index - valueRadius >= 0)
            {
                for (int i = 0; i <= valueRadius; i++)
                {
                    if (index < targets.Count)
                    {
                        targets.RemoveAt(index);
                    }

                }

                for (int i = 0; i < valueRadius; i++)
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        index--;
                        targets.RemoveAt(index);
                    }

                }
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            
            
        }

        private static void Shoot(List<int> targets, int index, int valueRadius)
        {
            if (index < targets.Count)
            {
                targets[index] -= valueRadius;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }

        private static void Add(List<int> targets, int index, int valueRadius)
        {
            if (index >= targets.Count)
            {
                Console.WriteLine("Invalid placement!");
                
            }
            else
            {
                targets.Insert(index, valueRadius);
            }
        }
    }
}
