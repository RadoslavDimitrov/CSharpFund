using System;
using System.Collections.Generic;

namespace TextProcessingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsers = new List<string>();
            bool isValid = false;
            isValid = FilterValidUsers(input, validUsers, isValid);
            PrintValidUsers(validUsers);
        }

        private static void PrintValidUsers(List<string> validUsers)
        {
            foreach (var item in validUsers)
            {
                Console.WriteLine(string.Join(Environment.NewLine, item));
            }
        }

        private static bool FilterValidUsers(string[] input, List<string> validUsers, bool isValid)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 2 && input[i].Length < 17)
                {
                    char[] currUser = input[i].ToCharArray();

                    for (int k = 0; k < currUser.Length; k++)
                    {
                        if (currUser[k] >= 48 && currUser[k] <= 57
                            || currUser[k] >= 65 && currUser[k] <= 90
                            || currUser[k] >= 97 && currUser[k] <= 122
                            || currUser[k] == 45 || currUser[k] == 95)
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsers.Add(input[i]);
                    }

                }
            }

            return isValid;
        }
    }
}
