using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string letters = Console.ReadLine();

                foreach (char c in letters)
                {
                    sum += (int)c;
                }
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
