using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 8; i <= n; i++)
            {
                bool divisable = DivisibleBy8(i);
                bool oddDigit = HasOddDigit(i);

                if(divisable == true && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
           
        }

        private static bool HasOddDigit(int num)
        {
            string textNum = num.ToString();
            for (int i = 0; i < textNum.Length; i++)
            {
                if((int)textNum[i] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool DivisibleBy8(int num)
        {
            int sum = 0;
            string textNum = num.ToString();

            for (int i = 0; i < textNum.Length; i++)
            {
                sum += textNum[i];
            }

            if(sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
