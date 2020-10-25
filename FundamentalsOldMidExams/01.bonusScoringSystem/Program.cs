using System;

namespace _01.bonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            byte studentCount = byte.Parse(Console.ReadLine());
            byte lecturesCount = byte.Parse(Console.ReadLine());
            byte initialBonus = byte.Parse(Console.ReadLine());

            //{total bonus} = {student attendances - readLine} / {lecturesCount} * (5 + {initialBonus})

            int attenndance = 0;
            double currBonus = 0;
            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                attenndance = int.Parse(Console.ReadLine());
                currBonus = (attenndance * 1.0 / lecturesCount * (5 + initialBonus));

                if(currBonus > maxBonus)
                {
                    maxBonus = currBonus;
                    maxAttendance = attenndance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
