using System;
using System.Linq;

namespace ArrayModifire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string command = string.Empty;
            

            while ((command = Console.ReadLine()) != "end")
            {
                string[] currInput = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(currInput[0] == "swap")
                {
                    //•	“swap {index1} {index2}” take two elements and swap their places.
                    SwapIndexes(input, currInput);
                }
                else if(currInput[0] == "multiply")
                {
                    //multiply {index1} {index2}
                    MultiplyIndexes(input, currInput);
                }
                else if(currInput[0] == "decrease")
                {
                    DecreaseArrWithOne(input);
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }

        private static void DecreaseArrWithOne(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] -= 1;
            }
        }

        private static void MultiplyIndexes(int[] input, string[] currInput)
        {
            int index1 = int.Parse(currInput[1]);
            int index2 = int.Parse(currInput[2]);
            int temp1 = input[index1];
            int temp2 = input[index2];
            int multipy = temp1 * temp2;
            input[index1] = multipy;
        }

        private static void SwapIndexes(int[] input, string[] currInput)
        {
            int index1 = int.Parse(currInput[1]);
            int index2 = int.Parse(currInput[2]);
            int temp1 = input[index1];
            int temp2 = input[index2];

            input[index1] = temp2;
            input[index2] = temp1;
        }
    }
}
