using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();
            
            if(firstWord.Length > secondWord.Length)
            {
                int sum = GetCharSum(firstWord, secondWord);
                Console.WriteLine(sum);
            }
            else if(secondWord.Length > firstWord.Length)
            {
                int sum = GetCharSum(secondWord, firstWord);
                Console.WriteLine(sum);
            }
            else
            {
                int sum = GetCharSum(secondWord, firstWord);
                Console.WriteLine(sum);
            }
        }

        private static int GetCharSum(char[] firstWord, char[] secondWord)
        {
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < secondWord.Length; i++)
            {
                sum += firstWord[i] * secondWord[i];
                counter++;
            }

            for (int i = counter; i < firstWord.Length; i++)
            {
                sum += firstWord[i];
            }

            return sum;
        }
    }
    // private static int GetCharSum(char[] first, char[] second)
    //{
    //    int sum = 0;
    //    int counter = 0;

    //    for (int i = 0; i < second.Length; i++)
    //    {
    //        sum += first[i] * second[i];
    //        counter++;
    //    }

    //    for (int i = counter; i < first.Length; i++)
    //    {
    //        sum += first[i];
    //    }

    //    return sum;
    //}
}


