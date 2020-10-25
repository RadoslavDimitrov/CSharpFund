using System;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string secondEle in secondArray)
            {
                foreach (string firstEle in firstArray)
                {
                    if(secondEle == firstEle)
                    {
                        Console.Write($"{secondEle} ");
                    }
                }
            }
        }
    }
}
