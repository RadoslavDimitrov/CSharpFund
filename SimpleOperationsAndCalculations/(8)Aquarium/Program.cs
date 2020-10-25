using System;

namespace _8_Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            // 2. Volume = length * width * height
            // 2.1 Volume liters = volume * 0.01

            // 3. Used space - Percent
            // 4. Free space = 2 - 3
            // 5. Print free space

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volumeInLiters = volume * 0.001;

            double numberPercent = percent * 0.01;
            double freeSpace = volumeInLiters * (1 - numberPercent);

            Console.WriteLine($"{freeSpace:F3}");
        }
    }
}
