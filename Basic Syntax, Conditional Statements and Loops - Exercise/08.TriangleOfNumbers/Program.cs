using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
