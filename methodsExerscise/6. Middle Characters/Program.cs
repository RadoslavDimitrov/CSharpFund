using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //hello
            PrintMiddleCharacter(text);
        }

        private static void PrintMiddleCharacter(string text)
        {
            if(text.Length % 2 == 1)
            {
                //1 middle char
                Console.WriteLine(text[text.Length / 2]);


            }
            else if(text.Length % 2 == 0)
            {
                //2 chars
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
        }
    }
}
