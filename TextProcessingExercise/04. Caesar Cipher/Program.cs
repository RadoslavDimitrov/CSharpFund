using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] encrypted = input.ToCharArray();

            

            for (int i = 0; i < encrypted.Length; i++)
            {
                int currChar = encrypted[i];
                currChar += 3;
                encrypted[i] = (char)currChar;
            }

            Console.WriteLine(encrypted);
        }
    }
}
