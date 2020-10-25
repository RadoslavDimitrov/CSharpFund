using System;

namespace _04.bus
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред - броят пътници в автобуса при потеглянето му - цяло число в интервала [1 ... 100]
            //•	На втория ред - броят на спирките -цяло число в интервала[1…50]
            //•	На следващите редове(равни на броят на спирките * 2) - броя на пътниците, които слизат и броя на 
            //                пътниците които се качват -цели числа в интервала[0…100]

            int numPasagers = int.Parse(Console.ReadLine());
            int numStops = int.Parse(Console.ReadLine());
            int numPplOff = 0;
            int numPplOn = 0;
            for (int i = 1; i <= numStops ; i++)
            {
                numPplOff = int.Parse(Console.ReadLine());
                numPplOn = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    numPasagers = (numPasagers - numPplOff) + numPplOn + 2;
                }
                else if (i % 2 == 0)
                {
                    numPasagers = (numPasagers - numPplOff - 2) + (numPplOn);
                }
               
            }
            Console.WriteLine($"The final number of passengers is : {numPasagers}");
        }
    }
}
