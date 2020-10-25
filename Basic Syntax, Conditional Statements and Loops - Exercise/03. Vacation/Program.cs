using System;
using System.Runtime.CompilerServices;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPpl = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();

            double priceForOne = 0;

            switch (day)
            {
                case "friday":
                    switch (typeOfGroup)
                    {
                        case "students":
                            priceForOne = 8.45;
                            break;
                        case "business":
                            priceForOne = 10.90;
                            break;
                        case "regular":
                            priceForOne = 15;
                            break;

                    }
                    break;
                case "saturday":
                    switch (typeOfGroup)
                    {
                        case "students":
                            priceForOne = 9.80;
                            break;
                        case "business":
                            priceForOne = 15.60;
                            break;
                        case "regular":
                            priceForOne = 20;
                            break;

                    }
                    break;
                case "sunday":
                    switch (typeOfGroup)
                    {
                        case "students":
                            priceForOne = 10.46;
                            break;
                        case "business":
                            priceForOne = 16;
                            break;
                        case "regular":
                            priceForOne = 22.50;
                            break;

                    }
                    break;

            }

            double totalPrice = priceForOne * numOfPpl;

            switch (typeOfGroup)
            {
                case "students":
                    if(numOfPpl >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "business":
                    if(numOfPpl >= 100)
                    {
                        totalPrice = totalPrice - (10 * priceForOne);
                    }
                    break;
                case "regular":
                    if (numOfPpl >= 10 && numOfPpl <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                    break;

            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
