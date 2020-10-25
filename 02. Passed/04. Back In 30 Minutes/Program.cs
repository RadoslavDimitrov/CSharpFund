using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            
            int minIn30 = min + 30;
            if(minIn30 > 59)
            {
                hour++;
                minIn30 -= 60;
                if(hour > 23)
                {
                    hour = 0;
                }
                
            }
            Console.WriteLine($"{hour}:{minIn30:D2}");

        }
    }
}
