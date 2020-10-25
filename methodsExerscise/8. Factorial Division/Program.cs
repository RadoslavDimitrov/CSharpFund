using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Math.Abs(int.Parse(Console.ReadLine()));
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));

            long factorialNum1 = GetFactorial(num1);
            long factorialNum2 = GetFactorial(num2);


            decimal finalResult = (decimal)factorialNum1 / factorialNum2;
            Console.WriteLine($"{finalResult:F2}");


        }

        private static long GetFactorial(long num)
        {
            //6*5*4*3*2*1
            long result = num;

            for (long i = num - 1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
