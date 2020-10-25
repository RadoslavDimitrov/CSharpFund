using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string inputString = "";

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        break;
                    }
                    else
                    {
                        counter += 1;
                    }
                }
                if (counter == array.Length - i - 1)
                {
                    inputString += array[i] + " ";
                }
            }
            Console.WriteLine(inputString);
        }
    }
}