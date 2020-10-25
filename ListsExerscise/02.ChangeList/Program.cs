using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "end")
            {
                if (command.Count == 2)
                {
                    DeleteElement(list, command);
                }
                else if(command.Count == 3)
                {
                    InsertElement(list, command);
                }

                command = Console.ReadLine().Split().ToList();

            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static List<int> InsertElement(List<int> list, List<string> command)
        {
            int element = int.Parse(command[1]);
            int position = int.Parse(command[2]);
            list.Insert(position, element);
            return list;
        }

        private static List<int> DeleteElement(List<int> list, List<string> command)
        {
            
            int element = int.Parse(command[1]);
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == element)
                {
                    list.Remove(element);
                    i--;
                }
            }

            return list;
        }
    }
}
