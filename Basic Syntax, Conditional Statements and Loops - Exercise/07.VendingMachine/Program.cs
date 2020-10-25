using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            double coins = 0;

            while (command != "Start")
            {
                
                switch (double.Parse(command))
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        coins += double.Parse(command);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept { command} ");
                        break;
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if(coins >= 2.0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            coins -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coins >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            coins -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coins >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            coins -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coins >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            coins -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coins >= 1.0)
                        {
                            Console.WriteLine($"Purchased coke");
                            coins -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coins:F2}");

        }
    }
}
