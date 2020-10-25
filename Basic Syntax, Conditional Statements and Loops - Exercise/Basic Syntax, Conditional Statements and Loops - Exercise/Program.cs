using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int divisable = int.MinValue;

            //2, 3, 6, 7, 10.

            if(num % 2 == 0)
            {
                divisable = 2;
            }
            if (num % 3 == 0)
            {
                divisable = 3;
            }
            if(num % 6 == 0)
            {
                divisable = 6;
            }
            if(num % 7 == 0)
            {
                divisable = 7;
            }
            if(num % 10 == 0)
            {
                divisable = 10;
            }
            if (divisable == int.MinValue)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisable}");
            }
            
        }
    }
}
