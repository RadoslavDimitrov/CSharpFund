using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = string.Empty;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                string midResult = numbers[i] + " ";
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        midResult += numbers[i] + " ";
                        
                    }
                    else
                    {
                        if(midResult.Length > result.Length)
                        {
                            result = midResult;
                        }
                        break;
                    }
                    if (midResult.Length > result.Length)
                    {
                        result = midResult;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
