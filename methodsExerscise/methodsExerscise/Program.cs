using System;

namespace methodsExerscise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = GetSmaller(num1,num2,num3);
            Console.WriteLine(result);
        }

        private static int GetSmaller(int a, int b, int c)
        {
            if(a < b && a < c)
            {
                return a;
            }
            else if(b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
