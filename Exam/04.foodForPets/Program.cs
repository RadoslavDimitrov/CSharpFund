using System;

namespace _04.foodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());
            double dogFoodSum = 0;
            double catFoodSum = 0;
            double totalFoodEaten = 0;
            double totalBiscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogFoodDay = int.Parse(Console.ReadLine());
                double catFoodDay = int.Parse(Console.ReadLine());

                dogFoodSum += dogFoodDay;
                catFoodSum += catFoodDay;
                totalFoodEaten += catFoodDay + dogFoodDay;
                if (i % 3 == 0)
                {
                    double biscuitsDay = (dogFoodDay + catFoodDay) * 0.1;
                    totalBiscuits += biscuitsDay;
                }
                    
            }

            double totalFoodEatenPer = totalFoodEaten / allFood * 100;
            double totalFoodDogEaten = dogFoodSum / totalFoodEaten * 100;
            double totalFoodCatEaten = catFoodSum / totalFoodEaten * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");
            Console.WriteLine($"{totalFoodEatenPer:F2}% of the food has been eaten.");
            Console.WriteLine($"{totalFoodDogEaten:F2}% eaten from the dog.");
            Console.WriteLine($"{totalFoodCatEaten:F2}% eaten from the cat.");
        }
    }
}
