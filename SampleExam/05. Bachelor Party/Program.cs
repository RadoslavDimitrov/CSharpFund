using System;

namespace _05._Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Сумата предвидена за гост изпълнителя - цяло число в интервала [1… 4500]
            //На всеки следващ ред(до получаване на команда "The restaurant is full") -броят на хората във всяка група.

            int sumSinger = int.Parse(Console.ReadLine());
            string numPplOrCommand = Console.ReadLine();
            int totalPpl = 0;
            int newPpl = 0;
            int totalSum = 0;

            while (numPplOrCommand != "The restaurant is full")
            {
                newPpl = int.Parse(numPplOrCommand);

                if(newPpl >= 5)
                {
                    totalSum += newPpl * 70;
                    totalPpl += newPpl;
                }
                else if (newPpl < 5)
                {
                    totalSum += newPpl * 100;
                    totalPpl += newPpl;
                }

                numPplOrCommand = Console.ReadLine();
            }
            int sumLeft = totalSum - sumSinger;
            if (sumLeft >= 0)
            {
                Console.WriteLine($"You have {totalPpl} guests and {sumLeft} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalPpl} guests and {totalSum} leva income, but no singer.");
            }
        }
    }
}
