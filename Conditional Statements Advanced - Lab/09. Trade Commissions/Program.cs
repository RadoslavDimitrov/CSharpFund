using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Град    0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000  s > 10 000
            //Sofia   5 %               7 %             8 %             12 %
            //Varna   4.5 %             7.5 %           10 %            13 %
            //Plovdiv 5.5 %             8 %             12 %            14.5 %

            //read input 
            //1. City
            //2. volume sells
            //3. output comission:F2
            //4. error
            // totalComission = sells * comission
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double comission = 0;

            if (city == "Sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comission = 0.05;
                }
                else if (sells <= 1000)
                {
                    comission = 0.07;
                }
                else if (sells <= 10000)
                {
                    comission = 0.08;
                }
                else if (sells > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comission = 0.045;
                }
                else if (sells <= 1000)
                {
                    comission = 0.075;
                }
                else if (sells <= 10000)
                {
                    comission = 0.10;
                }
                else if (sells > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comission = 0.055;
                }
                else if (sells <= 1000)
                {
                    comission = 0.08;
                }
                else if (sells <= 10000)
                {
                    comission = 0.12;
                }
                else if (sells > 10000)
                {
                    comission = 0.145;
                }
            }

            switch (city)
            {
                case "Sofia":
                case "Varna":
                case "Plovdiv":
                    
                    if (sells >= 0)
                    {
                        double totalComission = sells * comission;
                        Console.WriteLine($"{totalComission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;



            }

           

        }
    }
}
