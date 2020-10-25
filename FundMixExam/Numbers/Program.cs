using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            double averageSum = input.Sum() * 1.0 / input.Count;

            List<int> disorderedList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > averageSum)
                {
                    disorderedList.Add(input[i]);
                }
            }

            int temp = 0;

            disorderedList = disorderedList.OrderByDescending(x => x).ToList();
           
            //for (int i = 0; i < disorderedList.Count; i++)
            //{
            //    for (int j = i + 1; j < disorderedList.Count; j++)
            //    {
            //        if (disorderedList[i] < disorderedList[j])
            //        {
            //            temp = disorderedList[i];
            //            disorderedList[i] = disorderedList[j];
            //            disorderedList[j] = temp;
            //        }

            //    }

            //}

            if (disorderedList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (disorderedList.Count <= 5)
            {
                Console.WriteLine(string.Join(" ", disorderedList));
            }
            else
            {
                Console.WriteLine($"{disorderedList[0]} {disorderedList[1]} {disorderedList[2]} " +
                    $"{disorderedList[3]} {disorderedList[4]}");
            }
        }

        
    }
}
