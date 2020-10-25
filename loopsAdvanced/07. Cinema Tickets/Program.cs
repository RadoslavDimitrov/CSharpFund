using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;



            while (movie != "Finish")
            {
                int avaliableSeats = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                int currentTickets = 0;
                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                    }
                    currentTickets++;
                    if (currentTickets == avaliableSeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += currentTickets;
                double seedTaken = currentTickets * 1.0 / avaliableSeats * 100;
                Console.WriteLine($"{movie} - {seedTaken:F2}% full.");


                movie = Console.ReadLine();
            }
            double standardTicketsPercent = standardTickets * 1.0 / totalTickets * 100;
            double studentTicketsPercent = studentTickets * 1.0 / totalTickets * 100;
            double kidTicketsPercent = kidTickets * 1.0 / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:F2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:F2}% kids tickets.");
        }
    }
}
