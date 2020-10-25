using System;

namespace _06._Shelter_for_Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodForCatKg = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double foodForCatGr = foodForCatKg * 1000;
            double foodEatenAll = 0;
            while (command != "Adopted")
            {
                double foodEatenDay = double.Parse(command);
                foodEatenAll += foodEatenDay;
                command = Console.ReadLine();
            }
            if (foodForCatGr >= foodEatenAll)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodForCatGr - foodEatenAll} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodForCatGr - foodEatenAll)} grams more.");
            }

        }
    }
}
