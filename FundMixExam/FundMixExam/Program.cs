using System;

namespace FundMixExam
{
    class Program
    {
        static void Main(string[] args)
        {
            short firstEff = short.Parse(Console.ReadLine());
            short secondEff = short.Parse(Console.ReadLine());
            short thirdEff = short.Parse(Console.ReadLine());

            short combineEff = (short)(firstEff + secondEff + thirdEff);

            short studentsCount = short.Parse(Console.ReadLine());
            short hours = 0;
            short counter = 0;

            if (studentsCount == 0)
            {
                Console.WriteLine($"Time needed: {hours}h.");
                return;
            }

            while (studentsCount >= combineEff)
            {
                studentsCount -= combineEff;
                hours++;
                
                if (counter % 3 == 0 && counter > 2)
                {
                    hours++;
                    counter = 0;
                }
                counter++;
            }

            if(studentsCount > 0 && studentsCount < combineEff)
            {
                hours++;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
