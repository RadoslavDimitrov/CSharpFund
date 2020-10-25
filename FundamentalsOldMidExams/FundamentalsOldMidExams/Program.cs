using System;

namespace FundamentalsOldMidExams
{
    class Program
    {
        static void Main(string[] args)
        {
            short initialEnergy = short.Parse(Console.ReadLine());
            byte battlesWon = 0;
            //string command = string.Empty;
            bool isDead = false;
            string command = Console.ReadLine();

            while(command != "End of battle")
            {
                short distance = short.Parse(command);

                if(initialEnergy - distance >= 0)
                {
                    initialEnergy -= distance;
                    battlesWon++;
                    if(battlesWon % 3 == 0 && battlesWon > 2)
                    {
                        initialEnergy += battlesWon;
                    }
                }
                else if(initialEnergy - distance < 0)
                {
                    isDead = true;
                    Console.WriteLine($"Not enough energy! " +
                        $"Game ends with {battlesWon} won battles and {initialEnergy} energy");
                    break;
                }

                command = Console.ReadLine();
            }

            if(isDead == false)
            {
            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {initialEnergy}");
            }

        }
    }
}
