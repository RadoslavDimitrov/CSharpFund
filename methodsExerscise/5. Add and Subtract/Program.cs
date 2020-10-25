using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = Sum(num1, num2);
            Substract(result, num3);
        }

        private static void Substract(int result, int num3)
        {
            Console.WriteLine(result - num3);
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
