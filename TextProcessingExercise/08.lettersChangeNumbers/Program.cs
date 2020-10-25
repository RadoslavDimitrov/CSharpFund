using System;
using System.Runtime.ExceptionServices;
using System.Text;

namespace _08.lettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                StringBuilder sb = new StringBuilder(input[i]);
                char fisrtLetter = sb[0];
                char lastLetter = sb[sb.Length - 1];

                sb.Remove(0, 1);
                int lenght = sb.Length - 1;
                sb.Remove(lenght, 1);
                decimal number = decimal.Parse(Convert.ToString(sb));
                decimal midResult = 0;

                //Uppercase
                if(fisrtLetter >= 65 && fisrtLetter <= 90)
                {
                    midResult = number / (fisrtLetter - 64);
                }
                else //lowercase
                {
                    midResult = number * (fisrtLetter - 96);
                }

                //Uppercase lastLetter
                if(lastLetter >= 65 && lastLetter <= 90)
                {
                    midResult -= (lastLetter - 64);
                }
                else
                {
                    midResult += (lastLetter - 96);
                }

                sum += midResult;
            }

            Console.WriteLine($"{sum:F2}");
            

            



            
        }
    }
}
