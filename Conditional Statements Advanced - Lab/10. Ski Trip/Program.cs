using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // 11 => 10 nights
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceForOneNight = 0;
            double discount = 0;
            //⦁	"room for one person" – 18.00 лв за нощувка
            //⦁	"apartment" – 25.00 лв за нощувка
            //⦁	"president apartment" – 35.00 лв за нощувка

            if (typeOfRoom == "room for one person")
            {
                priceForOneNight = 18.00;
            }
            else if (typeOfRoom == "apartment")
            {   
                priceForOneNight = 25.00;
                if (days < 10)
                {
                    discount = 0.30;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                }
                else if (days > 15)
                {
                    discount = 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                priceForOneNight = 35.00;
                if (days < 10)
                {
                    discount = 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else if (days > 15)
                {
                    discount = 0.20;
                }
            }

            int night = days - 1;
            double totalPrice = night * priceForOneNight;

            totalPrice -= totalPrice * discount;

            if (feedback == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (feedback == "negative")
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
