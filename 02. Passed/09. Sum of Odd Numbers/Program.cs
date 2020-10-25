using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(num);
                sum += num;
                num += 2;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
        
    }
}
