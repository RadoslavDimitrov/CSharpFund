using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExerscise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                if (command.Count == 2)
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCapacity - wagons[i] > int.Parse(command[0]))
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }

                command = Console.ReadLine().Split().ToList();

            }
            

            Console.WriteLine(string.Join(" ", wagons));

            
        }

        

        
    }
}
