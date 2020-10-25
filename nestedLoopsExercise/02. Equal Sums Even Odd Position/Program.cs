using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
           

            for (int i = start; i <= end; i++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string numStr = i.ToString();
                for (int j = 0; j < numStr.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        oddSum += int.Parse(numStr[j].ToString());
                        
                    }
                    else
                    {
                        evenSum += int.Parse(numStr[j].ToString());
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }

                
            }
        }
    }
}
