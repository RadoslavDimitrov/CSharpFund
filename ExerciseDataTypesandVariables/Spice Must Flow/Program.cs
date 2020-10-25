using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int mined = 0;
            while (yield >= 100)
            {
                days++;
                
                mined += yield;
                mined -= 26;
                yield -= 10;
            }
            if(mined >= 26)
            {
                mined -= 26;
            }
            

            Console.WriteLine(days);
            Console.WriteLine(mined);
        }
    }
}
