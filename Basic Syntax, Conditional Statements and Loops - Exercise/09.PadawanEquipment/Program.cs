using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	The amount of money Ivan Cho has – floating-point number in range [0.00…1,000.00]
            //•	The count of students – integer in range[0…100]
            //•	The price of lightsabers for a single sabre – floating - point number in range[0.00…100.00]
            //•	The price of robes for a single robe – floating - point number in range[0.00…100.00]
            //•	The price of belts for a single belt – floating - point number in range[0.00…100.00]

            double money = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double beltsFree = numOfStudents / 6;

            double robeAndBeltPrice = (numOfStudents * robePrice) + (beltPrice * (numOfStudents - beltsFree));
            double numOfLightsabers = Math.Ceiling(numOfStudents + numOfStudents * 0.1);
            double lightsabersBuyed = numOfLightsabers * lightsaberPrice;

            double total = robeAndBeltPrice + lightsabersBuyed;

            if(money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money - total):F2}lv more.");
            }

        }


        
    }
}
