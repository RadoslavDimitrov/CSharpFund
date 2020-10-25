using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //string command = Console.ReadLine();
            List<string> currCommand = Console.ReadLine().Split().ToList();

            while (currCommand[0] != "End")
            {
                //List<string> currCommand = command.Split().ToList();

                if(currCommand[0] == "Add")
                {
                    AddNumber(numbers, currCommand);
                }
                else if(currCommand[0] == "Insert")
                {
                    InsertNumber(numbers, currCommand);
                }
                else if(currCommand[0] == "Remove")
                {
                    RemoveIndex(numbers, currCommand);
                }
                else if(currCommand[1] == "left")
                {
                    MoveLeft(numbers, currCommand);
                }
                else if(currCommand[1] == "right")
                {
                    MoveRight(numbers, currCommand);
                }

                //command = Console.ReadLine();
                currCommand = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> MoveRight(List<int> numbers, List<string> currCommand)
        {
            int count = int.Parse(currCommand[2]);
            if (count > numbers.Count)
            {
                count = count % numbers.Count;
            }
            for (int i = 0; i < count; i++)
            {
                int temp = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, temp);
            }
            return numbers;
        }

        private static List<int> MoveLeft(List<int> numbers, List<string> currCommand)
        {
            int count = int.Parse(currCommand[2]);
            if(count > numbers.Count)
            {
                count = count % numbers.Count;
            }
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
                
            }

            return numbers;
            
        }

        private static List<int> RemoveIndex(List<int> numbers, List<string> currCommand)
        {
            int index = int.Parse(currCommand[1]);
            if(index < numbers.Count && index >= 0)
            {
                numbers.RemoveAt(index);
                return numbers;
            }
            else
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }
            
        }

        private static List<int> InsertNumber(List<int> numbers, List<string> currCommand)
        {
            int index = int.Parse(currCommand[2]);
            int number = int.Parse(currCommand[1]);

            if (index < numbers.Count && index >= 0)
            {
                numbers.Insert(index, number);
                return numbers;
            }
            else
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }
            
        }

        private static List<int> AddNumber(List<int> numbers, List<string> currCommand)
        {
            int number = int.Parse(currCommand[1]);
            numbers.Add(number);
            return numbers;
        }
    }
}
