using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombPower[0];
            int power = bombPower[1];

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                int numbersCount = numbers.Count;

                if(indexOfBomb == -1)
                {
                    break;
                }

                int rightIndex = indexOfBomb + power;
                for (int i = indexOfBomb; i <= rightIndex; i++)
                {
                    if(i < numbersCount)
                    {
                        numbers.RemoveAt(indexOfBomb);
                    }
                    else
                    {
                        break;
                    }
                    
                }

                int leftIndex = indexOfBomb - power;
                for (int i = indexOfBomb - 1; i >= leftIndex; i--)
                {
                    if(i >= 0)
                    {
                        numbers.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }

            

            Console.WriteLine(numbers.Sum());
            

            


        }
    }
}
