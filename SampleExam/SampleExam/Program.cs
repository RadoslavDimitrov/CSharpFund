using System;

namespace SampleExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFoodFor1Day = double.Parse(Console.ReadLine());
            double moneyForSuvenires1Day = double.Parse(Console.ReadLine());
            double moneyForHotel1Day = double.Parse(Console.ReadLine());

            double gazLiters = 420.00 / 100 * 7;
            double gazMoney = gazLiters * 1.85;
            double moneyForFoodAndSuvenires = 3 * (moneyForFoodFor1Day + moneyForSuvenires1Day);
            double firstDayHotel = moneyForHotel1Day * 0.9;
            double secondDayHotel = moneyForHotel1Day * 0.85;
            double thirdDayHotel = moneyForHotel1Day * 0.8;

            double total = firstDayHotel + secondDayHotel + thirdDayHotel + moneyForFoodAndSuvenires + gazMoney;

            Console.WriteLine($"Money needed: {total:F2}");

        }
    }
}
