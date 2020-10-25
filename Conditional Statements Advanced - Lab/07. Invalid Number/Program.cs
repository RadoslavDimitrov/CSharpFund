using System;

namespace _07._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isTrue = (num >= 100 && num <= 200) || num == 0;
            
            if (!isTrue)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
