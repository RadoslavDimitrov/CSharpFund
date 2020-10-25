using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int currCard = 0;

            while (firstHand.Count != 0 && secondHand.Count != 0)
            {
                if(firstHand[currCard] > secondHand[currCard])
                {
                    int temp = firstHand[currCard];
                    firstHand.RemoveAt(currCard);
                    firstHand.Add(temp);
                    firstHand.Add(secondHand[currCard]);
                    secondHand.RemoveAt(currCard);

                }
                else if(firstHand[currCard] < secondHand[currCard])
                {
                    int temp = secondHand[currCard];
                    secondHand.RemoveAt(currCard);
                    secondHand.Add(temp);
                    secondHand.Add(firstHand[currCard]);
                    firstHand.RemoveAt(currCard);
                }
                else if(firstHand[currCard] == secondHand[currCard])
                {
                    firstHand.RemoveAt(currCard);
                    secondHand.RemoveAt(currCard);
                }
            }

            if(firstHand.Sum() > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else if(secondHand.Sum() > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}
