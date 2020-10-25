using System;
using System.Collections.Generic;
using System.Linq;

namespace HearthDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = string.Empty;
            List<string> jump = new List<string>();
            int cupidIndex = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                jump = command.Split().ToList();
                int jumpCount = command[1];

                if(cupidIndex + jumpCount < hood.Count)
                {
                    cupidIndex += jumpCount;

                    if(hood[cupidIndex] <= 0)
                    {
                        Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                        if(hood[cupidIndex] < 0)
                        {
                            hood[cupidIndex] = 0;
                        }
                    }
                    else
                    {
                        hood[cupidIndex] -= 2;

                        if(hood[cupidIndex] == 0)
                        {
                            Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                        }
                    }

                }
                else
                {
                    cupidIndex = 0;
                    if(hood[cupidIndex] > 0)
                    {
                        hood[cupidIndex] -= 2;
                        if (hood[cupidIndex] == 0)
                        {
                            Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                        }
                    }
                }
            }

            bool isMissionUnsuccessful = false;

            for (int i = 0; i < hood.Count; i++)
            {
                if(hood[i] != 0)
                {
                    isMissionUnsuccessful = true;
                }
            }

            List<int> housesLeft = hood.Where(x => x != 0).ToList();

            if(isMissionUnsuccessful == false)
            {
                Console.WriteLine($"Cupid's last position was {cupidIndex}.");
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid's last position was {cupidIndex}.");
                Console.WriteLine($"Cupid has failed {housesLeft.Count} places.");
            }
        }
    }
}
