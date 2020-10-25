using System;

namespace _7_YardGreeening
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 7.61 for square meter
            //2. 18% discount

            double scuareMeters = double.Parse(Console.ReadLine());
            double percents = 18 * 0.01;
            double priceWithoutDiscount = scuareMeters * 7.61;
            double priceWithDiscount = priceWithoutDiscount * (1 - percents);
            double discount = priceWithoutDiscount - priceWithDiscount;

            Console.WriteLine($"The final price is: {priceWithDiscount:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
