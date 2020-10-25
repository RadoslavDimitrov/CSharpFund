using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ theInteger} X { times} = { product}

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var product = num * i;
                Console.WriteLine($"{num } X {i} = {product}");
            }
        }
    }
}
