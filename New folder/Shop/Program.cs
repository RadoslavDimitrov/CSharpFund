using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = 1.5;
            double M = 2.5;
            double Veg = 10;
            double Fru = 10;

            double Earn = N * Veg + M * Fru;
            double EarnEu = Earn / 1.94;

            Console.WriteLine("{0:0.00}", EarnEu);
        }
    }
}
