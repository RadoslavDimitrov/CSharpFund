using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int countTheCombinations = 0;
            bool isMagicalNum = false;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    countTheCombinations++;

                    int sum = num1 + num2;
                    if(sum == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{countTheCombinations} ({num1} + {num2} = {magicalNumber})");
                        isMagicalNum = true;
                        break;
                    }
                }
                if (isMagicalNum == true)
                {
                    break;
                }
            }

            if (!isMagicalNum)
            {
                Console.WriteLine($"{countTheCombinations} combinations - neither equals {magicalNumber}");
            }
           
        }
    }
}
