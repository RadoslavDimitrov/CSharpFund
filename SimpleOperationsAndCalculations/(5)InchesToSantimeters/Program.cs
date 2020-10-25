using System;

namespace _5_InchesToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Read input
            //2. Convert to santimeters

            double inch = double.Parse(Console.ReadLine());
            double santimeters = inch * 2.54;
            Console.WriteLine(santimeters);
        }
    }
}
