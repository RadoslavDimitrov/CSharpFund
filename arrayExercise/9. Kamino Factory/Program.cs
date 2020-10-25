using System;
using System.Data;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lenght = byte.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            string result = "";
            while (command != "Clone them!")
            {
                string[] dnaSample = command.Split("!");
                int[] dnaNumbers = dnaSample.Select(int.Parse).ToArray();

                string midResult = "";
                for (int i = 0; i < dnaNumbers.Length; i++)
                {
                    if(dnaNumbers[i] == 1)
                    {
                        midResult += dnaNumbers[i] + " ";
                        //for (int j = i + 1; j < dnaNumbers.Length; j++)
                        //{
                        //    if(dnaNumbers[i] == dnaNumbers[j])
                        //    {
                        //        midResult += dnaNumbers[j];
                        //    }
                        //    else
                        //    {
                        //        break;
                        //    }
                        //}
                    }
                    else
                    {
                        if(midResult != "")
                        {
                            if(midResult.Length > result.Length)
                            {
                                result = midResult;
                            }
                        }
                        continue;
                    }
                }
            }

            




        }
    }
}
