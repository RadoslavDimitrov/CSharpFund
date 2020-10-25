using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            List<char> result = new List<char>();

            //List<char> forReplace = new List<char>();
            bool isFinish = false;

            int lastIndex = 0;

            while (true)
            {
                for (int i = lastIndex; i <= input.Length - 1; i++)
                {
                    //TODO check for similar characters
                    lastIndex++;

                    

                    if(i == input.Length - 2 && input[i] == input[i + 1])
                    {
                        result.Add(input[i]);
                        isFinish = true;
                        break;
                    }
                    else if(i == input.Length - 2 && input[i] != input[i + 1])
                    {
                        result.Add(input[i]);
                        result.Add(input[i + 1]);
                        isFinish = true;
                        break;
                    }

                    if (input[i] != input[i + 1])
                    {
                        result.Add(input[i]);
                        break;
                    }

                }

                if (isFinish)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
