using System;

namespace _6_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Dogs
            //2. Other animals
            //2.1 Food price
            //3 Final sume = 0.00lv

            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogsFood = dogs * 2.50;
            int otherAnimalsFood = otherAnimals * 4;
            double sumNeeded = dogsFood + otherAnimalsFood;

            Console.WriteLine($"{sumNeeded:F2} lv.");

        }
    }
}
