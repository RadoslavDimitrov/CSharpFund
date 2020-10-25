using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = "";
            double biggest = int.MinValue;
            string biggestKeg = "";

            for (int i = 0; i <  n; i++)
            {
                model = Console.ReadLine();
               
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;
                    if(volume > biggest)
                    {
                    biggest = volume;
                    biggestKeg = model;
                    }
               
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
