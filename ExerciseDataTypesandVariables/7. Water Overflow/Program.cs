using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //capacity =  255l

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int capacity = 255;
            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                
                if(capacity >= litters)
                {
                    capacity -= litters;
                    sum += litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
