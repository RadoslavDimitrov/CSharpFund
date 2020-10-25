using System;

namespace _1.poolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            // обем V
            // P1 and P2
            // N - time when pipes are working

            //1. Volume in L.
            //2. P1 for 1/h
            //3 P2 for 1/h
            //4 H -  hours pipes are working

            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalWater = p1 * hours + p2 * hours;
            double p1TotalWater = p1 * hours;
            double p2TotalWater = p2 * hours;

            double p1InPercent = (p1TotalWater / totalWater) * 100; 
            double p2InPercent = (p2TotalWater / totalWater) * 100;

            double volumeInPercent = totalWater / volume * 100;

            if (volume >= totalWater)
            {
                Console.WriteLine($"The pool is {volumeInPercent:F2}% full. Pipe 1: {p1InPercent:F2}%. Pipe 2: {p2InPercent:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {totalWater - volume:F2} liters."
);
            }
        }
    }
}
