using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            //room = 2m * 2m * (h = astronavtsH + 0.4)
            //•	На първия ред е широчината на кораба - реално число в интервала [1.00... 10.00]
            //•	На втория ред е  дължината на кораба - реално число в интервала[1.00…10.00]
            //•	На третия ред е височината на кораба - реално число в интервала[1.00…20.00]
            //•	На четвъртия ред е средната височина на астронавтите  -реално число в интервала[1.50 … 1.90]

            double craftWight = double.Parse(Console.ReadLine());
            double craftHeight = double.Parse(Console.ReadLine());
            double craftHight = double.Parse(Console.ReadLine());
            double astronavtsH = double.Parse(Console.ReadLine());

            double craftVolume = craftHeight * craftWight * craftHight;
            double roomVolume = 2 * 2 * (astronavtsH + 0.4);

            double astronavts = Math.Floor(craftVolume / roomVolume);

            if (astronavts >= 3 && astronavts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronavts} astronauts.");
            }
            else if (astronavts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronavts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
