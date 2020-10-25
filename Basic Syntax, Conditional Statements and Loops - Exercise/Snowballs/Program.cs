using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSwonballs = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQ = 0;
            

            double snowballValueMax = double.MinValue;

            for (int i = 0; i < numOfSwonballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQ = int.Parse(Console.ReadLine());
                

                double snowballValue = snowballSnow * 1.0 / snowballTime;
                double snowballValueOnSquare = snowballValue;
                for (int k = 0; k < snowballQ - 1; k++)
                {
                    snowballValueOnSquare = snowballValueOnSquare * snowballValue;
                }
                if(snowballValueOnSquare > snowballValueMax)
                {
                    snowballValueMax = snowballValueOnSquare;
                }

            }

            Console.WriteLine($"{snowballSnow}{snowballTime}{snowballValueMax}{snowballQ}");
        }
    }
}
