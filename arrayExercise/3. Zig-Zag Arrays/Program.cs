using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                int[] newNumbs = Console.ReadLine().Split().Select(int.Parse).ToArray();


                if(counter == 1)
                {
                    firstArray[i] = newNumbs[0];
                    secondArray[i] = newNumbs[1];
                    counter++;
                }
                else if(counter == 2)
                {
                    firstArray[i] = newNumbs[1];
                    secondArray[i] = newNumbs[0];
                    counter--;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
