using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = num.ToString();
            int sum = 0;
            int sum2 = 0;

            for (int j = 0; j < text.Length; j++)
            {
                sum = text[j];
                sum2 = sum2 + (sum - 48);
            }
          
            Console.WriteLine(sum2);
            
        }
    }
}
