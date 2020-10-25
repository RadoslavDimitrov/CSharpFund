using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //5. free space = area of hall - area of wardrobe - area of bench
            //6. numOfDancers = free space / 7040
            //7. print dancers = Math.Floor

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double areaOfHall = (length * 100) * (width * 100);
            double areaWardrobe = (wardrobeSide * 100) * (wardrobeSide * 100);
            double areaBench = areaOfHall / 10;
            double freeSpace = areaOfHall - areaWardrobe - areaBench;
            double dancers = freeSpace / 7040;

            Console.WriteLine(Math.Floor(dancers));

        }
    }
}
