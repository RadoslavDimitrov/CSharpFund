using System;

namespace _07.AlkoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double wiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;

            double totalPrice = (rakiaPrice * rakiaLiters) + (wineLiters * winePrice) + (beerLiters * beerPrice) + (wiskeyPrice * wiskeyLiters);

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
