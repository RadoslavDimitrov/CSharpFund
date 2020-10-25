using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.read input = num tables, length tables , wigth tables = meters
            //2. покривки = length tables + 2 * 0.3 , wigth tables + 2 * 0.3
            //3. карета = sideKare = length table / 2 = area = sideKare * sideKare
            //4. price pokr. = 7 USD m2
            //5. price kare = 9 USD m2

            double tables = double.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWigth = double.Parse(Console.ReadLine());

            double tableCloth = tables * (tableLength + 2 * 0.3) * (tableWigth + 2 * 0.3);
            double sideQuads = tableLength / 2;
            double quads = tables * sideQuads * sideQuads;
            double usd = tableCloth * 7 + quads * 9;
            double bgn = usd * 1.85;

            Console.WriteLine($"{usd:F2} USD");
            Console.WriteLine($"{bgn:F2} BGN");

        }
    }
}
