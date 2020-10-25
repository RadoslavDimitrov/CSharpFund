using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Символ 1: цифра от 1 до n.
            //•	Символ 2: цифра от 1 до n.
            //   •	Символ 3: малка буква измежду първите l букви на латинската азбука.
            //•	Символ 4: малка буква измежду първите l букви на латинската азбука.
            //•	Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int ackiiCode = 96;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= ackiiCode + l; k++)
                    {
                        for (char m = 'a'; m <= ackiiCode + l; m++)
                        {
                            for (int x = 1; x <= n; x++)
                            {
                                if (x > i && x > j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{x} ");
                                }
                                   
                            }
                        }
                    }
                }
            }

        }
    }
}
