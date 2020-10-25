using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holydays = int.Parse(Console.ReadLine()); //75

            int workingDays = 365 - holydays;  // 290
            int workPlay = workingDays * 63;  //18 270
            int holydayPlay = holydays * 127; // 9 525

            int normForPlay = 30000;
            int totalPlay = holydayPlay + workPlay; // 27 795
            int normDifference = normForPlay - totalPlay; // 2 205

            int hours = normDifference / 60; // 36
            int minutes = normDifference - 60 * hours; // 05

            if (totalPlay > normForPlay)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes less for play") ;
            }
        }
    }
}
