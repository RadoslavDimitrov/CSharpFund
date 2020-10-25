using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            int explodionPower = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == '>')
                {
                    explodionPower = int.Parse(Convert.ToString(sb[i + 1]));

                    for (int j = 1; j <= explodionPower; j++)
                    {
                        if(i + j >= sb.Length)
                        {
                            break;
                        }
                        if(sb[i + j] != '>')
                        {
                            sb.Remove(i + j, 1);
                            j--;
                            explodionPower--;
                        }
                        else
                        {
                            explodionPower += int.Parse(Convert.ToString(sb[i + j + 1]));
                            j--;
                            i++;
                        }
                    }
                }
            }

            Console.WriteLine(sb);
   
        }
    }
}
