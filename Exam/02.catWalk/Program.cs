using System;

namespace _02.catWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред - минути разходка на ден - цяло число в интервала [1...50]
            //•	На втория ред - броят на разходките дневно - цяло число в интервала[1…10]
            //•	На третия ред - приетите от котката калории на ден – цяло число в интервала[100…4000]


            int walkMinutes = int.Parse(Console.ReadLine());
            int walkNum = int.Parse(Console.ReadLine());
            int calloriesDay = int.Parse(Console.ReadLine());

            // 1 minute = 5call
            //Walk enought = 50% callDay
            int walkSum = walkMinutes * walkNum;
            int calloriesBurned = walkSum * 5;

            if(calloriesBurned >= calloriesDay / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {calloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {calloriesBurned}.");
            }
        }
    }
}
