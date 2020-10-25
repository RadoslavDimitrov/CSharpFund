using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] currCommand = command.Split(">>>");

                if(currCommand[0] == "Contains")
                {
                    CheckAndPrint(key, currCommand);
                }
                else if(currCommand[0] == "Flip")
                {
                    key = FlipAndPrintKey(key, currCommand);
                }
                else   //Slice
                {
                    key = SliceAndPrintKey(key, currCommand);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        private static string SliceAndPrintKey(string key, string[] currCommand)
        {
            int startIndex = int.Parse(currCommand[1]);
            int endIndex = int.Parse(currCommand[2]);

            int cutLength = endIndex - startIndex;

            key = key.Remove(startIndex, cutLength);

            Console.WriteLine(key);
            return key;
        }

        private static string FlipAndPrintKey(string key, string[] currCommand)
        {
            int startIndex = int.Parse(currCommand[2]);
            int endIndex = int.Parse(currCommand[3]);

            int lenght = endIndex - startIndex;

            string substr = key.Substring(startIndex, lenght);

            if (currCommand[1] == "Upper")
            {

                string newSub = substr.ToUpper();

                key = key.Replace(substr, newSub);

                Console.WriteLine(key);
            }
            else //toLower
            {
                string newSubToLower = substr.ToLower();

                key = key.Replace(substr, newSubToLower);

                Console.WriteLine(key);
            }

            return key;
        }

        private static void CheckAndPrint(string key, string[] currCommand)
        {
            string substring = currCommand[1];

            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
