using System;

namespace _2_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //  лицето на квадрат
            // S = a * a
            int sideA = int.Parse(Console.ReadLine());
            int area = sideA * sideA;
            Console.WriteLine(area);
        }
    }
}
