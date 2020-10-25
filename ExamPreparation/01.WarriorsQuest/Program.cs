using System;
using System.Linq;

namespace _01.WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                string[] currArray = command.Split().ToArray();

                string currCommand = currArray[0];

                switch (currCommand)
                {
                    case "GladiatorStance":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                            break;
                    case "DefensiveStance":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
