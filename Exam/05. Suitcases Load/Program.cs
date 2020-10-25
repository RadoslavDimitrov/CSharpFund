using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkVolume = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalSuitcaseVouyme = 0;
            int numSuitcases = 0;
            int counter = 1;
            while (command != "End")
            {

                double suitcaseVouyme = double.Parse(command);
                if (counter % 3 == 0)
                {
                    suitcaseVouyme *= 1.1;
                }
                trunkVolume -= suitcaseVouyme;
                if(trunkVolume <= 0)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                numSuitcases++;
                counter++;
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {numSuitcases} suitcases loaded.");
        }
    }
}
