using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            short firstEfficiency = short.Parse(Console.ReadLine());
            short secondEfficiency = short.Parse(Console.ReadLine());
            short thirdEfficiency = short.Parse(Console.ReadLine());

            short totalPpl = short.Parse(Console.ReadLine());

            short pplPerHour = (short)(firstEfficiency + secondEfficiency + thirdEfficiency);

            short hours = 0;
            byte counter = 0;

            if(totalPpl == 0)
            {
                Console.WriteLine($"Time needed: {hours}h.");
                return;
            }

            while (totalPpl >= pplPerHour)
            {
                if (totalPpl - pplPerHour >= 0)
                {
                    totalPpl -= pplPerHour;
                    hours++;
                    counter++;
                    if (counter % 3 == 0 && counter > 2 && totalPpl > 0)
                    {
                        hours++;
                        counter = 0;
                    }
                    
                }
                
            }

            if (totalPpl < pplPerHour && totalPpl > 0)
            {
                hours++;
            }


            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
