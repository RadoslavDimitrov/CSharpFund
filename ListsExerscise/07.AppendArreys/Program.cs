using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArreys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> firstOrder = new List<string>();
            MakeFirstOrder(numbers, firstOrder);
            List<string> secondOrder = new List<string>();
            MakeSecondOrder(firstOrder, secondOrder);

            Console.WriteLine(string.Join(" ", secondOrder));

        }

        private static void MakeSecondOrder(List<string> firstOrder, List<string> secondOrder)
        {
            for (int i = 0; i < firstOrder.Count; i++)
            {

                List<string> currList = firstOrder[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int k = 0; k < currList.Count; k++)
                {
                    secondOrder.Add(currList[k]);
                }
            }
        }

        private static void MakeFirstOrder(List<string> numbers, List<string> firstOrder)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                firstOrder.Add(numbers[i]);
            }
        }


    }
}
