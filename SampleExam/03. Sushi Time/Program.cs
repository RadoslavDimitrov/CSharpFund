using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Видът суши –  текст  –  една от възможностите: "sashimi", "maki", "uramaki", "temaki"
            //•	Име на ресторанта – текст – една от възможностите: "Sushi Zone", "Sushi Time", "Sushi Bar", "Asian Pub"
            //•	Брой порции – цяло число в интервала[1…100]
            //•	Поръчка – символ – 'Y' - Delivery + 20% или 'N' - at Restaurant

            string sushi = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char deliveryOfNot = char.Parse(Console.ReadLine());
            double pricePerPortion = 0;
            switch (restaurantName)
            {
                case "Sushi Zone":
                    switch (sushi)
                    {
                        case "sashimi":
                            pricePerPortion = 4.99;
                            break;
                        case "maki":
                            pricePerPortion = 5.29;
                            break;
                        case "uramaki":
                            pricePerPortion = 5.99;
                            break;
                        case "temaki":
                            pricePerPortion = 4.29;
                            break;
                        
                    }
                    break;
                case "Sushi Time":
                    switch (sushi)
                    {
                        case "sashimi":
                            pricePerPortion = 5.49;
                            break;
                        case "maki":
                            pricePerPortion = 4.69;
                            break;
                        case "uramaki":
                            pricePerPortion = 4.49;
                            break;
                        case "temaki":
                            pricePerPortion = 5.19;
                            break;

                    }

                    break;
                case "Sushi Bar":
                    switch (sushi)
                    {
                        case "sashimi":
                            pricePerPortion = 5.25;
                            break;
                        case "maki":
                            pricePerPortion = 5.55;
                            break;
                        case "uramaki":
                            pricePerPortion = 6.25;
                            break;
                        case "temaki":
                            pricePerPortion = 4.75;
                            break;

                    }
                    break;
                case "Asian Pub":
                    switch (sushi)
                    {
                        case "sashimi":
                            pricePerPortion = 4.50;
                            break;
                        case "maki":
                            pricePerPortion = 4.80;
                            break;
                        case "uramaki":
                            pricePerPortion = 5.50;
                            break;
                        case "temaki":
                            pricePerPortion = 5.50;
                            break;

                    }
                    break;
                default:
                    Console.WriteLine($"{restaurantName} is invalid restaurant!");
                    return;
                   
            }
            double total = portions * pricePerPortion;

            if (deliveryOfNot == 'Y')
            {
                total = total + total * 0.2;
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }

        }
    }
}
