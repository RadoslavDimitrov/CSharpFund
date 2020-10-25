using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(j < i)
                    {
                        leftSum += numbers[j];
                    }
                    else if(j > i)
                    {
                        rightSum += numbers[j];
                    }
                }
                if(numbers.Length == 1)
                {
                    leftSum = 0;
                    rightSum = 0;
                    Console.WriteLine(0);
                    return;
                }
                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                
            }

            Console.WriteLine("no");
        }
    }
}
