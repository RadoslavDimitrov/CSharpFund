using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //n = aaa,aab,aac,aba,abb,abc
            for (int i = 97; i < n + 97; i++)
            {
                for (int j = 97; j < n + 97; j++)
                {
                    for (int k =97; k < n + 97; k++)
                    {
                        char first = (char)i;
                        char secont = (char)j;
                        char third = (char)k;
                        Console.WriteLine($"{first}{secont}{third}");
                    }
                }
            }
        }
    }
}
