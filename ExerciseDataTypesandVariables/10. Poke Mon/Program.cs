using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //N   //n == 50%N ex
            int distance = int.Parse(Console.ReadLine());  //M
            byte exhaustionFactor = byte.Parse(Console.ReadLine()); //Y
            double exPoint = (double)pokePower / 2;
            int targets = 0;
            //do
            //{
            //    pokePower -= distance;
            //    targets++;
            //    if(exPoint == pokePower)
            //    {
            //        pokePower = pokePower / exhaustionFactor;

            //    }
            //} while (pokePower >= distance);

            while (pokePower >= distance)
            {
                
                if(exPoint == pokePower)
                {
                    if(exhaustionFactor > 0)
                    {
                        pokePower = pokePower / exhaustionFactor;
                        if(pokePower < distance)
                        {
                            break;
                        }
                    }
                    

                }


                pokePower -= distance;
                targets++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targets);

        }
    }
}
