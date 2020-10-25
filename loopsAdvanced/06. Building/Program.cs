using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int numOfFloor = floors; numOfFloor > 0; numOfFloor--)
            {
                for (int numOfRooms = 0; numOfRooms < rooms; numOfRooms++)
                {
                    if (numOfFloor == floors)
                    {
                        Console.Write($"L{numOfFloor}{numOfRooms} ");
                    }
                    if(numOfFloor % 2 == 0 && numOfFloor != floors)
                    {
                        Console.Write($"O{numOfFloor}{numOfRooms} ");
                    }
                    if (numOfFloor % 2 != 0 && numOfFloor != floors)
                    {
                        Console.Write($"A{numOfFloor}{numOfRooms} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
