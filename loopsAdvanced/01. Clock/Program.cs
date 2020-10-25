using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTime = false;

            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    if (hours == 7 && minutes == 30)
                    {
                        Console.Beep(277, 1600);
                        isTime = true;
                        break;
                    }
                    Console.WriteLine($"{hours}:{minutes}");
                }
                if (isTime)
                {
                    break;
                }
            }
        }
    }
}
