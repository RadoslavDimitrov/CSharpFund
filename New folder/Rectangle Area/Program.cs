using System;

namespace Rectangle_Area
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            var C = double.Parse(Console.ReadLine());
            var F = C * 1.8 + 32;
            Console.Write("Fahrenheit = ");
            Console.Write("{0:0.00}", F);
            
        }
    }
}
