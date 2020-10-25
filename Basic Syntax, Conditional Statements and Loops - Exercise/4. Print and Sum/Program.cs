using System;

namespace _4._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start;  i <= end; i++)
            {
                if(i != end)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.WriteLine(i);
                }
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
