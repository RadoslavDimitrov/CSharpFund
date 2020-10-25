using System;

namespace _03.fitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Сумата, с която разполагаме - реално число в интервала [10.00…1000.00]
            //•	Пол - символ('m' за мъж и 'f' за жена)
            //•	Възраст - цяло число в интервала[5…105]
            //•	Спорт - текст(една от възможностите в таблицата)

            double money = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;
            switch (gender)
            {
                case 'm':
                    switch (sport)
                    {
                        case "Gym":
                            price = 42;
                            break;
                        case "Boxing":
                            price = 41;
                            break;
                        case "Yoga":
                            price = 45;
                            break;
                        case "Zumba":
                            price = 34;
                            break;
                        case "Dances":
                            price = 51;
                            break;
                        case "Pilates":
                            price = 39;
                            break;

                    }
                    break;
                case 'f':
                    switch (sport)
                    {
                        case "Gym":
                            price = 35;
                            break;
                        case "Boxing":
                            price = 37;
                            break;
                        case "Yoga":
                            price = 42;
                            break;
                        case "Zumba":
                            price = 31;
                            break;
                        case "Dances":
                            price = 53;
                            break;
                        case "Pilates":
                            price = 37;
                            break;
                    }
                    break;
              
            }
            if (age <= 19)
            {
                price *= 0.8;
            }

            if (price <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double moneyNeeded = price - money;
                Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:F2} more.");
            }

        }
    }
}
