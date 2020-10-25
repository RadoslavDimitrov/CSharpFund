using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int result = GetNumberOfVowels(word);
            Console.WriteLine(result);
        }

        private static int GetNumberOfVowels(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'o':
                    case 'u':
                    case 'e':
                    case 'i':
                        counter++;
                        break;
                }

            }

            return counter;
        }
    }
}
