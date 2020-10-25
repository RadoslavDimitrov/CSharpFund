using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                if(command[0] == "3:1")
                {
                    break;
                }

                if(command[0] == "merge")
                {
                    MergeElements(text, command);
                }
                else if(command[0] == "divide")
                {
                    DivideElements(text, command);
                }

            }




        }

        private static void DivideElements(List<string> text, List<string> command)
        {
            //•	divide {index} {partitions}
            //partitions = how many peaces will index become
            int index = int.Parse(command[1]);
            string elementForDividion = text[index];
            int chuncks = int.Parse(command[2]);

            int peaces = elementForDividion.Length / chuncks;
            string dividedElement = "";
            for (int i = 0; i < peaces; i++)
            {
                dividedElement += elementForDividion[i];
            }
            
        }

        private static List<string> MergeElements(List<string> text, List<string> command)
        {
            //•	merge {startIndex} {endIndex}
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            for (int i = endIndex; i > startIndex; i--)
            {
                text[i] = text[i] + text[i - 1];
                text.RemoveAt(i - 1);
            }
            
            string elementForReverse = ReverseElement(text, startIndex);
            text.RemoveAt(startIndex);
            text.Insert(startIndex, elementForReverse);

            return text;
        }

        private static string  ReverseElement(List<string> text, int startIndex)
        {
            string element = text[startIndex];
            string reversedElement = "";

            for (int i = element.Length - 1; i >= 0; i--)
            {
                string currEle = element[i].ToString();
                reversedElement += currEle;
                  
            }

            return reversedElement;
        }
    }
}
