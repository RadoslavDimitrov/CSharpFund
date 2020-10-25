using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            double bgnRound = Math.Round(bgn, 2);

            Console.WriteLine($"{bgnRound:F2}");
        }
    }
}
